var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//user secret file generated in belw path
//C:\Users\admin\AppData\Roaming\Microsoft\UserSecrets\11215851-97b4-4fe2-b99a-0086f614125a
//<UserSecretsId>11215851-97b4-4fe2-b99a-0086f614125a</UserSecretsId>

/*
Enable user secrets using dotnet cmd prompt
dotnet user-secrets init
To list the available secrets
dotnet user-secrets list
Set Secret Key
dotnet user-secrets set "AuthorApiKey" "xyz1@3"
Access a secret
Using IConfiguration config
 */

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
