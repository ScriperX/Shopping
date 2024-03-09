using Microsoft.EntityFrameworkCore;
using Shopping.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//Se le agrega al builder (que es el que construye la app) otro servicio, que es una base de datos
builder.Services.AddDbContext<DataContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});//Aquí le decimmos que String de conexión usar con builder.Configuration.GetConnectionString("DefaultConnection")

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
