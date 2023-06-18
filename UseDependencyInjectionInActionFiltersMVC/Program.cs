using Microsoft.AspNetCore.Mvc;
using UseDependencyInjectionInActionFiltersMVC.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register a custom action filter class CustomActionFilter in ASP.NET
builder.Services.AddScoped<CustomActionFilter>();

//4. Use global action filters in ASP.NET Core
IMvcBuilder mvcBuilder = builder.Services.AddControllers(config =>
{
    config.Filters.Add<CustomActionFilter>();
    //This enables you to apply the filter to every action method of every controller in your project
    //One of the biggest benefits of dependency injection is that it allows you to build applications that are loosely coupled.
}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
builder.Services.AddControllersWithViews();

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
