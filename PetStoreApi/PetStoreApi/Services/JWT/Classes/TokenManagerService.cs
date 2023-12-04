using Microsoft.AspNetCore.Identity;
using PetStoreApi.Services.JWT.Interfaces;

namespace PetStoreApi.Services.JWT.Classes;
public class TokenManagerService : ITokenManagerService
{
    private readonly ITokenCreationService _tokenCreationService;
    private readonly ITokenRefreshService _tokenRefreshService;

    public TokenManagerService(ITokenCreationService tokenCreationService, ITokenRefreshService tokenRefreshService)
    {
        _tokenCreationService = tokenCreationService;
        _tokenRefreshService = tokenRefreshService;
    }

    public string CreateToken(IdentityUser user)
    {
        return _tokenCreationService.CreateToken(user);
    }

    public string RefreshToken(string token)
    {
        return _tokenRefreshService.RefreshToken(token);
    }
}