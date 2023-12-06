using Microsoft.AspNetCore.Identity;
using PetStoreApi.Models.JWT;

namespace PetStoreApi.Services.JWT.Interfaces;

public interface ITokenCreationService
{
    public AuthResponse CreateToken(IdentityUser user);
}
