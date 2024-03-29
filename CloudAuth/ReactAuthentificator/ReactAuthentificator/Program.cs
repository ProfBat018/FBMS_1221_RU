using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReactAuthentificator.Areas.Identity.Data;
using ReactAuthentificator.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ReactAuthentificatorContextConnection") ?? throw new InvalidOperationException("Connection string 'ReactAuthentificatorContextConnection' not found.");

builder.Services.AddDbContext<ReactAuthentificatorContext>(options => options.UseSqlServer(builder.Configuration
    .GetConnectionString("Default")));

builder.Services.AddDefaultIdentity<ReactAuthentificatorUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ReactAuthentificatorContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();