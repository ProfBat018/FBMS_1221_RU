namespace PetStoreApi.Models.JWT;

public class AuthResponse
{
    public string Username { get; set; } 
    public string Email { get; set; }
    public string Token { get; set; }
}
