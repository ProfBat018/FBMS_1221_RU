using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PetsData.DbContexts;
using PetStoreApi.DbContexts;
using PetStoreApi.Services;
using System.Diagnostics;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(ops =>
                    ops.AddPolicy("AllowAnyOrigins", builder => builder.AllowAnyOrigin()));

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddDbContext<PetDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["DefaultConnection"]);
});

builder.Services.AddDbContext<UsersContext>(options =>
{
    options.UseSqlServer(builder.Configuration["UserDefaultConnection"]);
});


builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ClockSkew = TimeSpan.FromMinutes(30), // Мой токен будет жить 30 минут  
            ValidateIssuer = true, // укзывает, будет ли валидироваться издатель при валидации токена
            ValidateAudience = true, // будет ли валидироваться потребитель токена
            ValidateLifetime = true, // будет ли валидироваться время существования
            ValidateIssuerSigningKey = true, // валидация ключа безопасности
            ValidIssuer = "apiWithAuthBackend", // строка, представляющая издателя
            ValidAudience = "apiWithAuthBackend", // установка потребителя токена
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["IssuerKey"])
            ), // установка ключа безопасности для входа сервера 
        };
    });

builder.Services
    .AddIdentityCore<IdentityUser>(options =>
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


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAnyOrigins");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

