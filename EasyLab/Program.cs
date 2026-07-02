using DevExpress.Blazor;
using EasyLab.Components;
using EasyLab.Models;
using EasyLab.Models.Local;
using EasyLab.Servizi;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options =>
    {
        options.DetailedErrors = builder.Environment.IsDevelopment();
    });

builder.Services.AddDevExpressBlazor();

builder.Services.AddSingleton<StateKeeperService>();



// Recupera la stringa di connessione
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registra la DbContextFactory (consigliata per Blazor)
builder.Services.AddDbContextFactory<SeaseTstContext>(options =>
    options.UseSqlServer(connectionString, sql => sql.UseCompatibilityLevel(120)));

builder.Services.AddDbContext<EasyLabDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));


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
app.MapPost("/auth/logout", async (SignInManager<ApplicationUser> signInManager) =>
{
    await signInManager.SignOutAsync();
    return Results.LocalRedirect("/login");
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


using (var scope = app.Services.CreateScope())
{
    var myRoleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "LocalAdmin", "Standard", "Modelist" };

    foreach (var role in roles)
    {
        if (!await myRoleManager.RoleExistsAsync(role))
        {
            await myRoleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // Primo utente Admin: serve per poter accedere e usare la pagina Gestione Utenti,
    // che altrimenti nessuno potrebbe raggiungere per crearne uno tramite l'interfaccia.
    // DA RIMUOVERE (o cambiare credenziali) quando si passa in produzione.
    var myUserManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    if (await myUserManager.FindByNameAsync("1") is null)
    {
        var primoAdmin = new ApplicationUser
        {
            UserName = "Admin",
            EmailConfirmed = true
        };

        var creazione = await myUserManager.CreateAsync(primoAdmin, "Admin1?");
        if (creazione.Succeeded)
        {
            await myUserManager.AddToRoleAsync(primoAdmin, "Admin");
        }
    }
}

app.Run();
