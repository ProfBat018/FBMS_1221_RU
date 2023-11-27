using Microsoft.AspNetCore.Identity;

namespace PetStoreApi.Services;

public interface ITokenManagerService
{
    Task<bool> IsCurrentActiveTokenAsync();
    Task DeactivateCurrentAsync();
    Task<bool> IsActiveAsync(string token);
    Task DeactivateAsync(string token);
    public string CreateToken(IdentityUser user);
}
