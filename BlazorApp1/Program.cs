using BlazorApp1.Components;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Data;  // Add this for AppDbContext

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<AppDbContext>(options => 
    options.UseSqlite("Data Source=app.db"));

builder.Services.AddDbContextFactory<AppDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// HTTPS Configuration (to remove the HTTPS warning):
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenLocalhost(5003, listenOptions =>
    {
        listenOptions.UseHttps();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// app.UseMigrationsEndPoint(); // Removed because it's not available for WebApplication
app.UseStaticFiles();
app.UseRouting();

// Add this line for anti-forgery support
app.UseAntiforgery();

app.Run();
