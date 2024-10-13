using Microsoft.EntityFrameworkCore;
using StoreDbConnection.BLL.Services;
using StoreDbConnection.DAL.Context;
using StoreDbConnection.DAL.Repositories;
using StoreDbConnection.Domain.Abstractions;
using StoreDbConnection.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("StoreConnection");

builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IRepository<Category>, CategoryRepository>();
builder.Services.AddScoped<CategoryService>();

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
