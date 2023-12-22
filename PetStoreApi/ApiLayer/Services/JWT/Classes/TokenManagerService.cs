using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PetStoreApi.Models.JWT;
using PetStoreApi.Services.JWT.Interfaces;

namespace PetStoreApi.Services.JWT.Classes;
public class TokenManagerService : ITokenManagerService
{
    private readonly ITokenCreationService _tokenCreationService;
    private readonly ITokenRefreshService _tokenRefreshService;
    private readonly IConfiguration _configuration;

    public TokenManagerService(ITokenCreationService tokenCreationService, ITokenRefreshService tokenRefreshService, IConfiguration configuration)
    {
        _tokenCreationService = tokenCreationService;
        _tokenRefreshService = tokenRefreshService;
        _configuration = configuration;
    }

    public AuthResponse CreateToken(IdentityUser user)
    {
        return _tokenCreationService.CreateToken(user);
    }

    public string RefreshToken()
    {
        return _tokenRefreshService.RefreshToken();
    }

    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"])),
            ValidateLifetime = false
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
        if (securityToken is not JwtSecurityToken jwtSecurityToken || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            throw new SecurityTokenException("Invalid token");

        return principal;
    }
}