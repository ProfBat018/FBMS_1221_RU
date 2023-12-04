using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStoreApi.DbContexts;
using PetStoreApi.Models.Identity;
using PetStoreApi.Models.JWT;
using PetStoreApi.Services.JWT.Interfaces;
using System.Runtime.CompilerServices;

namespace PetStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UsersContext _context;
    private readonly ITokenCreationService _tokenService;

    public AuthController(UserManager<IdentityUser> userManager, ITokenCreationService tokenService, UsersContext context, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _context = context;
        _roleManager = roleManager;
    }

    [Route("/Register")]
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
    {
        var user = new IdentityUser
        {
            UserName = request.Username,
            Email = request.Email
        };

        if (user.Email.Contains("petshop.org"))
        {
            var role = await _roleManager.FindByNameAsync(IdentityData.Admin);
            if (role == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(IdentityData.Admin));
            }
            await _userManager.AddToRoleAsync(user, IdentityData.Admin);
        }
        else
        {
            var role = await _roleManager.FindByNameAsync(IdentityData.User);
            if (role == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(IdentityData.User));
            }
            await _userManager.AddToRoleAsync(user, IdentityData.User);
        }


        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }
        return Ok();
    }

    [Route("/Login")]
    [HttpPost]
    public async Task<IActionResult> Login([FromBody] AuthRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var managedUser = await _userManager.FindByEmailAsync(request.Email);
        if (managedUser == null)
        {
            return BadRequest("Bad credentials");
        }
        var isPasswordValid = await _userManager.CheckPasswordAsync(managedUser, request.Password);
        if (!isPasswordValid)
        {
            return BadRequest("Bad credentials");
        }

        var userInDb = _context.Users.FirstOrDefault(u => u.Email == request.Email);
        if (userInDb is null)
            return Unauthorized();

        var accessToken = _tokenService.CreateToken(userInDb);

        await _context.SaveChangesAsync();

        return Ok(new { token = accessToken });
    }
}
