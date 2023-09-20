using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MinimalApi;

var builder = WebApplication.CreateBuilder(args); // Тот самый паттерн строитель

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CarsDbContext>(opts => 
    opts.UseSqlite(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => JsonSerializer.Serialize(new { Message = "Hello World!" }));

app.MapGetCars();


app.Run();