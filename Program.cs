using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetshopApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PetShopAppContext>(options =>
    {
        var connectionString = builder.Configuration.GetConnectionString("PetShopAppContext");

        if(builder.Environment.IsDevelopment()) {
            options.UseSqlite(connectionString);
        } else {
            options.UseSqlServer(connectionString);
        }
    }
);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    // Turbante Caminhoneiro Louco Maluco Psicopata Pedófilo
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Inicializar(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Erro ao semear a base de dados!");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
