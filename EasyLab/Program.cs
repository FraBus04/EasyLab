using System.Data;
using DevExpress.Blazor;
using EasyLab.Components;
using EasyLab.Components.Utils;
using EasyLab.Models;
using EasyLab.Models.Local;
using EasyLab.Servizi;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options =>
    {
        options.DetailedErrors = builder.Environment.IsDevelopment();
    });

builder.Services.AddDevExpressBlazor();

builder.Services.AddSingleton<StateKeeperService>();
builder.Services.AddScoped<DropdownPortalService>();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton(sp => new AviTranscoderService
{
    FfmpegPath = builder.Configuration["Ffmpeg:Path"] ?? "ffmpeg"
});
builder.Services.AddSingleton(sp => new OfficeToPdfConverterService
{
    SofficePath = builder.Configuration["LibreOffice:Path"] ?? "soffice"
});



// Recupera la stringa di connessione
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registra la DbContextFactory (consigliata per Blazor)
builder.Services.AddDbContextFactory<SeaseTstContext>(options =>
    options.UseSqlServer(connectionString, sql => sql.UseCompatibilityLevel(120)));

builder.Services.AddDbContextFactory<EasyLabDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));
builder.Services.AddScoped(sp =>
    sp.GetRequiredService<IDbContextFactory<EasyLabDbContext>>().CreateDbContext());


builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false; //DA CAMBIARE IN TRUE QUANDO SI PASSA IN PRODUZIONE
})
    .AddEntityFrameworkStores<EasyLabDbContext>()
    .AddDefaultTokenProviders();

// Il cookie di Identity, per default, reindirizza le richieste non autenticate a
// "/Account/Login" e quelle non autorizzate (ruolo mancante) a "/Account/AccessDenied":
// pagine che non esistono in questa app. Le puntiamo a quelle vere.
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";
    options.AccessDeniedPath = "/";
});

builder.Services.AddCascadingAuthenticationState();

//builder.Services.AddLocalization();
//builder.Services.AddControllers();

var app = builder.Build();

// SeaseTstContext viene costruito forzatamente per evitare attesa al login
using (var warmupScope = app.Services.CreateScope())
{
    var warmupFactory = warmupScope.ServiceProvider.GetRequiredService<IDbContextFactory<SeaseTstContext>>();
    using var warmupContext = warmupFactory.CreateDbContext();
    _ = warmupContext.Model;
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Endpoint di login "reale": riceve un form-post HTML (non una chiamata Blazor interattiva),
// così puo' scrivere il cookie di autenticazione sulla risposta HTTP prima che Blazor la assuma.
app.MapPost("/auth/login", async (
    SignInManager<ApplicationUser> signInManager,
    [FromForm] string username,
    [FromForm] string password) =>
{
    var result = await signInManager.PasswordSignInAsync(username, password, isPersistent: true, lockoutOnFailure: true);

    if (result.Succeeded)
    {
        return Results.LocalRedirect("/");
    }

    return Results.LocalRedirect("/login?error=1");
});

// Stesso discorso del login: il sign-out deve avvenire su una risposta HTTP vera
// per poter cancellare il cookie di autenticazione.
// Esposto sia in POST (bottone Logout nell'header) sia in GET (redirect da un componente
// Blazor interattivo, es. dopo che l'admin cambia la propria password: non può fare un
// vero form-post da lì, ma una navigazione con forceLoad sì).
async Task<IResult> EseguiLogout(SignInManager<ApplicationUser> signInManager, string? returnUrl)
{
    await signInManager.SignOutAsync();
    return Results.LocalRedirect(string.IsNullOrEmpty(returnUrl) ? "/login" : returnUrl);
}
app.MapPost("/auth/logout", (SignInManager<ApplicationUser> signInManager, [FromForm] string? returnUrl) => EseguiLogout(signInManager, returnUrl));
app.MapGet("/auth/logout", (SignInManager<ApplicationUser> signInManager, string? returnUrl) => EseguiLogout(signInManager, returnUrl));

// Cambio password self-service (utenti non-Admin, dalla pagina /Utenti).
// Dopo il cambio si forza il logout: l'utente deve rientrare con la nuova password,
// invece di continuare la sessione corrente.
app.MapPost("/auth/change-password", async (
    HttpContext httpContext,
    UserManager<ApplicationUser> userManager,
    SignInManager<ApplicationUser> signInManager,
    [FromForm] string currentPassword,
    [FromForm] string newPassword,
    [FromForm] string confirmPassword) =>
{
    var user = await userManager.GetUserAsync(httpContext.User);
    if (user == null)
    {
        return Results.LocalRedirect("/login");
    }

    if (newPassword != confirmPassword)
    {
        return Results.LocalRedirect("/Utenti?pwderror=mismatch");
    }

    var result = await userManager.ChangePasswordAsync(user, currentPassword, newPassword);
    if (!result.Succeeded)
    {
        return Results.LocalRedirect("/Utenti?pwderror=1");
    }

    await signInManager.SignOutAsync();
    return Results.LocalRedirect("/login?pwdchanged=1");
}).RequireAuthorization();

// Serve i file della cartella Documentale di un articolo (letti dal filesystem del server).
// Usato dalla tab "Documentale" di Articoli: l'anteprima (img/iframe/video/audio) punta
// direttamente a questo URL invece di incorporare il file come data URI, perche' Chrome
// non renderizza in modo affidabile PDF/video di dimensioni non banali passati come data URI.
app.MapGet("/documentale/file", async (
    string cartella,
    string file,
    bool? scarica,
    IDbContextFactory<SeaseTstContext> dbFactory,
    IMemoryCache cache,
    AviTranscoderService aviTranscoder,
    OfficeToPdfConverterService officeConverter) =>
{
    if (string.IsNullOrWhiteSpace(cartella) || string.IsNullOrWhiteSpace(file))
        return Results.BadRequest();

    // Il nome file deve essere un nome semplice: niente separatori di percorso o "..".
    if (file.IndexOfAny(new[] { '/', '\\' }) >= 0 || file.Contains(".."))
        return Results.BadRequest();

    // Un client (es. il viewer PDF del browser) puo' emettere molte richieste Range per
    // lo stesso file: senza cache ognuna riapriva una connessione al db per rileggere
    // doc.Classi_Path, rendendo l'apertura visibilmente lenta.
    var radici = await cache.GetOrCreateAsync("documentale:radici", async entry =>
    {
        entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
        using var context = await dbFactory.CreateDbContextAsync();
        return await context.ClassiPaths.AsNoTracking()
            .Select(c => c.Path)
            .Where(p => !string.IsNullOrWhiteSpace(p))
            .ToListAsync();
    }) ?? new List<string?>();

    // La cartella richiesta deve ricadere sotto una delle radici configurate in doc.Classi_Path:
    // evita che il parametro "cartella" venga usato per leggere file arbitrari dal server.
    string cartellaNormalizzata;
    try
    {
        cartellaNormalizzata = Path.GetFullPath(cartella);
    }
    catch
    {
        return Results.BadRequest();
    }

    var valida = radici.Any(r => cartellaNormalizzata.StartsWith(Path.GetFullPath(r!), StringComparison.OrdinalIgnoreCase));
    if (!valida) return Results.StatusCode(StatusCodes.Status403Forbidden);

    var percorsoCompleto = Path.Combine(cartellaNormalizzata, file);
    if (!System.IO.File.Exists(percorsoCompleto)) return Results.NotFound();

    // I browser non riproducono l'AVI nel tag <video> (codec/contenitore non supportati):
    // per l'anteprima (non per il download) lo si converte al volo in mp4 con ffmpeg,
    // in cache su disco cosi' la conversione avviene una sola volta per file.
    if (Path.GetExtension(percorsoCompleto).Equals(".avi", StringComparison.OrdinalIgnoreCase) && scarica != true)
    {
        try
        {
            var mp4 = await aviTranscoder.GetMp4Async(percorsoCompleto);
            return Results.File(mp4, "video/mp4", enableRangeProcessing: true);
        }
        catch (Exception ex)
        {
            return Results.Problem(detail: ex.Message, statusCode: StatusCodes.Status503ServiceUnavailable, title: "Conversione video non riuscita");
        }
    }

    // DevExpress non ha un visualizzatore per Word/Excel/PowerPoint: per l'anteprima
    // (non per il download) questi formati vengono convertiti al volo in PDF con
    // LibreOffice e mostrati con lo stesso iframe gia' usato per i PDF nativi.
    string[] estensioniOffice = [".ppt", ".pptx", ".doc", ".docx", ".odt", ".xls", ".xlsx", ".rtf"];
    if (estensioniOffice.Contains(Path.GetExtension(percorsoCompleto).ToLowerInvariant()) && scarica != true)
    {
        try
        {
            var pdf = await officeConverter.GetPdfAsync(percorsoCompleto);
            return Results.File(pdf, "application/pdf", enableRangeProcessing: true);
        }
        catch (Exception ex)
        {
            return Results.Problem(detail: ex.Message, statusCode: StatusCodes.Status503ServiceUnavailable, title: "Conversione documento non riuscita");
        }
    }

    var provider = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
    if (!provider.TryGetContentType(percorsoCompleto, out var contentType))
        contentType = "application/octet-stream";

    return Results.File(percorsoCompleto, contentType, fileDownloadName: scarica == true ? file : null, enableRangeProcessing: true);
}).RequireAuthorization();

// Helper comuni ai due endpoint di stampa report sotto: validazione del nome file .rdlc (niente
// separatore di percorso o "..", stesso controllo di /documentale/file), parsing degli id in
// query string, e rendering finale con ReportViewerCore.NETCore (Microsoft.Reporting.NETCore.LocalReport).
static string? RisolviPercorsoReport(string nome, string sottocartella, IWebHostEnvironment env)
{
    if (string.IsNullOrWhiteSpace(nome) || nome.IndexOfAny(new[] { '/', '\\' }) >= 0 || nome.Contains(".."))
        return null;

    var percorso = Path.Combine(env.WebRootPath, "Report", sottocartella, nome);
    if (!string.Equals(Path.GetExtension(percorso), ".rdlc", StringComparison.OrdinalIgnoreCase)
        || !System.IO.File.Exists(percorso))
        return null;

    return percorso;
}

static List<int> LeggiIds(string ids) => (ids ?? string.Empty)
    .Split(',', StringSplitOptions.RemoveEmptyEntries)
    .Select(s => int.TryParse(s, out var id) ? id : (int?)null)
    .Where(id => id.HasValue)
    .Select(id => id!.Value)
    .Distinct()
    .ToList();

static byte[] RenderizzaReport(string percorsoReport, DataTable tabella, bool immaginiEsterne = false)
{
    using var fs = System.IO.File.OpenRead(percorsoReport);
    var report = new Microsoft.Reporting.NETCore.LocalReport();
    report.LoadReportDefinition(fs);
    report.DataSources.Add(new Microsoft.Reporting.NETCore.ReportDataSource("DataSet1", tabella));
    report.EnableExternalImages = immaginiEsterne;
    return report.Render("PDF");
}

// Report basati su VBasiMateriali (materiali): "ids" sono IdMat.
app.MapGet("/report/stampa-materiali", async (
    string nome,
    string ids,
    IDbContextFactory<SeaseTstContext> dbFactory,
    IWebHostEnvironment env) =>
{
    var percorsoReport = RisolviPercorsoReport(nome, "Materiale", env);
    if (percorsoReport == null)
        return Results.NotFound();

    var idMat = LeggiIds(ids);
    if (idMat.Count == 0)
        return Results.BadRequest("Nessun materiale selezionato.");

    using var context = await dbFactory.CreateDbContextAsync();
    var righe = await context.VBasiMaterialis.AsNoTracking()
        .Where(m => idMat.Contains(m.IdMat))
        .ToListAsync();

    var tabella = GestioneMaterialiRdlcBuilder.Build(righe);

    return Results.File(RenderizzaReport(percorsoReport, tabella), "application/pdf");
}).RequireAuthorization();

// Report basati su VElencoProdotti2 (prodotti): "ids" sono Id modello (IdMod), non IdMat.
app.MapGet("/report/stampa-prodotti", async (
    string nome,
    string ids,
    IDbContextFactory<SeaseTstContext> dbFactory,
    IWebHostEnvironment env) =>
{
    var percorsoReport = RisolviPercorsoReport(nome, "Prodotto", env);
    if (percorsoReport == null)
        return Results.NotFound();

    var idMod = LeggiIds(ids);
    if (idMod.Count == 0)
        return Results.BadRequest("Nessun prodotto selezionato.");

    using var context = await dbFactory.CreateDbContextAsync();
    var righe = await context.VElencoProdotti2s.AsNoTracking()
        .Where(m => idMod.Contains(m.Id))
        .ToListAsync();

    var idContatti = righe.Select(r => r.IdContatto).Distinct().ToList();
    var loghi = await context.Contattis.AsNoTracking()
        .Where(c => idContatti.Contains(c.Id))
        .ToDictionaryAsync(c => c.Id, c => c.PathLogo);

    var idStatoMod = righe.Where(r => r.IdStatoMod.HasValue).Select(r => r.IdStatoMod!.Value).Distinct().ToList();
    var statiModello = await context.TabStatoModellos.AsNoTracking()
        .Where(s => idStatoMod.Contains(s.Id))
        .ToDictionaryAsync(s => s.Id, s => (s.StatoMod, s.Cod));

    var tabella = GestioneProdottiRdlcBuilder.Build(righe, loghi, statiModello);

    // A differenza dei report materiali, questo referenzia immagini esterne (foto prodotto/logo).
    return Results.File(RenderizzaReport(percorsoReport, tabella, immaginiEsterne: true), "application/pdf");
}).RequireAuthorization();

// Report Sintesi Fasi Commesse: non e' un .rdlc caricato da disco, ma un vero XtraReport compilato 
app.MapGet("/report/stampa-commesse", (int idComm) =>
{
    if (idComm <= 0)
        return Results.BadRequest("Nessuna commessa selezionata.");

    var report = new EasyLab.ReportsVb.XtraReport_CommesseFasi3Sintesi();
    report.ImpostaConnessione(connectionString!);
    report.ImpostaIdCommessa(idComm);

    using var stream = new MemoryStream();
    report.ExportToPdf(stream, new DevExpress.XtraPrinting.PdfExportOptions());

    return Results.File(stream.ToArray(), "application/pdf");
}).RequireAuthorization();

// Report Sintesi Stato Commesse: non riguarda una singola commessa ma la selezione filtrata
// corrente di FasiCommesse.razor, gia' sincronizzata su Sel_ST (idClasse=130) dall'ultima
// ricerca (Cerca()). idClasse e idUte sono gli stessi usati per scrivere quelle righe.
app.MapGet("/report/stampa-commesse-stato", (int idClasse, int idUte) =>
{
    if (idClasse <= 0 || idUte < 0)
        return Results.BadRequest("Parametri non validi.");

    var report = new EasyLab.ReportsVb.XtraReport_Produz_GeneCommesse_Testa_AvanzFasi();
    report.ImpostaConnessione(connectionString!);
    report.ImpostaParametri(idClasse, idUte);

    using var stream = new MemoryStream();
    report.ExportToPdf(stream, new DevExpress.XtraPrinting.PdfExportOptions());

    return Results.File(stream.ToArray(), "application/pdf");
}).RequireAuthorization();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


using (var scope = app.Services.CreateScope())
{
    var myRoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "SuperAdmin", "Admin", "Standard", "Modellista", "Laboratorio", "CQ", "Ufficio" };

    foreach (var role in roles)
    {
        if (!await myRoleManager.RoleExistsAsync(role))
        {
            await myRoleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // Primo utente SuperAdmin: serve per poter accedere e usare la pagina Gestione Utenti
    // senza restrizioni (SuperAdmin vede tutte le compagnie, Admin solo la propria),
    // che altrimenti nessuno potrebbe raggiungere per crearne uno tramite l'interfaccia.
    // DA RIMUOVERE (o cambiare credenziali) quando si passa in produzione.
    var myUserManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    if (await myUserManager.FindByNameAsync("Admin") is null)
    {
        var primoAdmin = new ApplicationUser
        {
            UserName = "Admin",
            EmailConfirmed = true
        };

        var creazione = await myUserManager.CreateAsync(primoAdmin, "Admin1?");
        if (creazione.Succeeded)
        {
            await myUserManager.AddToRoleAsync(primoAdmin, "SuperAdmin");
        }
    }
}

app.Run();
