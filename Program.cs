using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAppFormMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// configurar entity framework core
builder.Services.AddDbContext<ApplicationDbContext>(Options =>
Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConecction")));

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
