using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CookieAuth.Data;
using CookieAuth.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CookieAuthContextConnection") ?? throw new InvalidOperationException("Connection string 'CookieAuthContextConnection' not found.");

builder.Services.AddDbContext<CookieAuthContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CookieAuthUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CookieAuthContext>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
