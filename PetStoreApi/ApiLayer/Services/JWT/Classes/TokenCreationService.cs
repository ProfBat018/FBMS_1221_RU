using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using PetStoreApi.Models.JWT;
using PetStoreApi.Services.JWT.Interfaces;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PetStoreApi.Services.JWT.Classes
{
    public class TokenCreationService : ITokenCreationService
    {
        private const int ExpirationMinutes = 30;

        private readonly IConfiguration _configuration;
        public TokenCreationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AuthResponse CreateToken(IdentityUser user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            }; 

            var signingCredentials = new SigningCredentials(
                               new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"])),
                                              SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                   issuer: _configuration["JwtSettings:Issuer"],
                   audience: _configuration["JwtSettings:Audience"],
                   claims: claims,
                   expires: DateTime.UtcNow.AddMinutes(ExpirationMinutes),
                   signingCredentials: signingCredentials);

            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new AuthResponse()
            {
                Token = tokenString,
                ValidTo = token.ValidTo.ToLocalTime().ToString(CultureInfo.InvariantCulture)
            };
        }
    }
}
