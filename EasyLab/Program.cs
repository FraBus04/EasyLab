using DevExpress.Blazor;
using EasyLab.Components;
using EasyLab.Models;
using EasyLab.Servizi;
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

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
