using System.Security.Claims;

namespace PetStoreApi.Services.JWT.Interfaces;

public interface ITokenRefreshService
{
    public string RefreshToken();
}