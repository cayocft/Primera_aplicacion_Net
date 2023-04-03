using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Primera_aplicacion_1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Para la base de datos
builder.Services.AddDbContext<PrimeraAplicacionContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("ConexionDb"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.25-mariadb")));
//Fin para la Base de datos

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
