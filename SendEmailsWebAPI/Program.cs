using MailKit.Net.Smtp;
using MimeKit;
using Org.BouncyCastle.Crypto.Tls;
using System.Configuration;
using SendEmailsWebAPI.SendEmails;

//Specify email configuration metadata in ASP.NET Core appsettings.json file.
var builder = WebApplication.CreateBuilder(args);

//1. Install the MailKit NuGet package
//4. read the email configuration data from the appsettings.json file into an instance of NotificationMetadata class.
var notificationMetadata = builder.Services.Configure<NotificationMetadata>(builder.Configuration.GetSection("Formatting"));
builder.Services.AddSingleton(notificationMetadata);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
