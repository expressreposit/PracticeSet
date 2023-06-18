using MultipleInterfaceImplements.Repositories.Interface;
using MultipleInterfaceImplements.Repositories;
using MultipleInterfaceImplements.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICustomLogger, FileLogger>();
builder.Services.AddScoped<ICustomLogger, DbLogger>();
builder.Services.AddScoped<ICustomLogger, EventLogger>();

//Use a delegate to retrieve a specific service instance
builder.Services.AddScoped<FileLogger>();
builder.Services.AddScoped<DbLogger>();
builder.Services.AddScoped<EventLogger>();

//Return instances based on service type at runtime
builder.Services.AddTransient<ServiceResolver>(serviceProvider => serviceTypeName =>
{
    switch (serviceTypeName)
    {
        case ServiceType.FileLogger:
            return serviceProvider.GetService<FileLogger>();
        case ServiceType.DbLogger:
            return serviceProvider.GetService<DbLogger>();
        case ServiceType.EventLogger:
            return serviceProvider.GetService<EventLogger>();
        default:
            return null;
    }
});

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
