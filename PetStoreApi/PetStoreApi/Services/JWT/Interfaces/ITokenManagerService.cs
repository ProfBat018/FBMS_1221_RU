using Microsoft.AspNetCore.Identity;
using PetStoreApi.Models.JWT;
using System.Security.Claims;

namespace PetStoreApi.Services.JWT.Interfaces;
public interface ITokenManagerService
{
    public AuthResponse CreateToken(IdentityUser user);
    public string RefreshToken();
    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string? token);
}
