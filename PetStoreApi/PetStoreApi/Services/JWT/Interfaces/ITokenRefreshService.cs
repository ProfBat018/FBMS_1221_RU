namespace PetStoreApi.Services.JWT.Interfaces;

public interface ITokenRefreshService
{
    public string RefreshToken(string token);
}