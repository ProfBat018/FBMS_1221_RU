using Microsoft.AspNetCore.Identity;

namespace PetStoreApi.Services;

public interface ITokenService
{
    public string CreateToken(IdentityUser user);
}
