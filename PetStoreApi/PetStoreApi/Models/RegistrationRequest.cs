using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PetStoreApi.Models;

public class RegistrationRequest 
{
    [Required]
    public string Email { get; set; } 
    [Required]
    public string Username { get; set; } 
    [Required]
    public string Password { get; set; }
}
