using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PetsData.DbContexts;
using PetStoreApi.DbContexts;
using PetStoreApi.Services.JWT.Classes;
using PetStoreApi.Services.JWT.Interfaces;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using PetStoreApi.Models.Identity;

namespace PetStoreApi;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(ops =>
        {
            ops.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
            });

            ops.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
        });
        
        services
            .AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _configuration["JwtSettings:Issuer"],
                    ValidAudience = _configuration["JwtSettings:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]))
                };
            });

        
        //services.ConfigureOptions<ConfigureJwtOptions>();
        //services.ConfigureOptions<JwtOptionsSetup>();


        services.AddAuthorization();

        services
            .AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
            })
            .AddEntityFrameworkStores<UsersContext>();

  

        services.AddCors(ops =>
                            ops.AddPolicy("AllowAnyOrigins", builder => builder.AllowAnyOrigin()));


        services.AddTransient<ITokenCreationService, TokenCreationService>();
        services.AddTransient<ITokenRefreshService, TokenRefreshService>();
        services.AddTransient<ITokenManagerService, TokenManagerService>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


        // Redis

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = _configuration.GetConnectionString("Redis");
            options.InstanceName = "PetStoreApi";
        });


        // DbContext 
        services.AddDbContext<PetDbContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnectionRemote"));
        });
        services.AddDbContext<UsersContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnectionRemote"));
        });
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseCors("AllowAnyOrigins");

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
    }
}
