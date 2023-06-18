using GlobalExceptionHandlingMVC;
using GlobalExceptionHandlingMVC.ErrorsHandler;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseCustomMiddleWare();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Error/NotFound/{0}");
}
//Use the UseExceptionHandler extension method in ASP.NET Core.
app.UseExceptionHandler(builder =>
             {
                 builder.Run(async context =>
                 {
                     context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                     context.Response.ContentType = "application/json";
                     var exception = context.Features.Get<IExceptionHandlerFeature>();
                     if (exception != null)
                     {
                         var error = new ErrorMessage()
                         {
                             Stacktrace = exception.Error.StackTrace,
                             Message = exception.Error.Message
                         };
                         var errObj = JsonConvert.SerializeObject(error);
                         await context.Response.WriteAsync(errObj).ConfigureAwait(false);
                     }
                 });
             }
        );
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
