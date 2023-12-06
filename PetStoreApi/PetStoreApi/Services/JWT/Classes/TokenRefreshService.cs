using System.Security.Claims;
using PetStoreApi.Services.JWT.Interfaces;
using System.Security.Cryptography;

namespace PetStoreApi.Services.JWT.Classes;
public class TokenRefreshService : ITokenRefreshService
{
    public string RefreshToken()
    {
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}
