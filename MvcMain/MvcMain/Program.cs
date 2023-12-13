using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MvcMain.Areas.Identity.Data;
using System.Globalization;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("UsersContextConnection") ?? throw new InvalidOperationException("Connection string 'UserDataContextConnection' not found.");

builder.Services.AddLocalization(o => o.ResourcesPath = "Resources");

builder.Services.AddControllersWithViews()
     .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
     .AddDataAnnotationsLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("az-AZ"),
        new CultureInfo("ru-RU")
    };

    options.DefaultRequestCulture = new RequestCulture("az-AZ");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    RequestCultureProvider requestProvider = options.RequestCultureProviders.OfType<CookieRequestCultureProvider>().First();
    options.RequestCultureProviders.Remove(requestProvider);

});

builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
        {
            googleOptions.ClientId = builder.Configuration["GoogleAuth:ClientId"];
            googleOptions.ClientSecret = builder.Configuration["GoogleAuth:ClientSecret"];
        });

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<UsersContext>();
builder.Services.AddAuthorization();


builder.Services.AddRazorPages();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();


app.MapControllerRoute(
       name: "default",
          pattern: "{area=User}/{controller=Home}/{action=Index}/{id?}");

app.Run();
