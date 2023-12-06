//using System.Text;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.Extensions.Options;
//using Microsoft.IdentityModel.Tokens;

//namespace PetStoreApi.Options;
//public class JwtOptionsSetup : IConfigureOptions<JwtBearerOptions>
//{
//    private readonly IConfiguration _configuration;
//    public JwtOptionsSetup(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }
//    public void Configure(JwtBearerOptions options)
//    {
//        options.TokenValidationParameters = new()
//        {
//            ValidateIssuer = true,
//            ValidateAudience = true,
//            ValidateLifetime = true,
//            ValidateIssuerSigningKey = true,
//            ValidIssuer = _configuration["JwtSettings:Issuer"],
//            ValidAudience = _configuration["JwtSettings:Issuer"],
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]))
//        };
//    }
//}
