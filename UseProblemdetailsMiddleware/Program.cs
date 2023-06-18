using Hellang.Middleware.ProblemDetails;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// This would add the required services to the DI container
builder.Services.AddProblemDetails();

// Customize the behavior of the ProblemDetails middleware in ASP.NET Core
builder.Services.AddProblemDetails(opts =>
{
    opts.IncludeExceptionDetails = (context, ex) =>
    {
        var environment = context.RequestServices.GetRequiredService<IHostEnvironment>();
        return environment.IsDevelopment();
    };
});
        
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
// Add the middleware to the request processing pipeline
app.UseProblemDetails();


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
