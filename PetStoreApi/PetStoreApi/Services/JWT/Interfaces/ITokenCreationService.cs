using Microsoft.AspNetCore.Identity;
using PetStoreApi.Models.JWT;

namespace PetStoreApi.Services.JWT.Interfaces;

public interface ITokenCreationService
{
    public string CreateToken(IdentityUser user);
}
