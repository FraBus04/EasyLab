using DevExpress.Blazor;
using EasyLab.Components;
using EasyLab.Models;
using EasyLab.Models.Local;
using EasyLab.Servizi;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
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

}

app.Run();
