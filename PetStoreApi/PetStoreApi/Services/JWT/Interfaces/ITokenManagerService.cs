using Microsoft.AspNetCore.Identity;

namespace PetStoreApi.Services.JWT.Interfaces;
public interface ITokenManagerService
{
    public string CreateToken(IdentityUser user);
    public string RefreshToken(string token);
}
