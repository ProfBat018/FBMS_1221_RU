using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStoreApi.DbContexts;
using PetStoreApi.Models.Identity;
using PetStoreApi.Models.JWT;
using PetStoreApi.Services.JWT.Interfaces;
using Serilog;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace PetStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UsersContext _context;
    private readonly ITokenManagerService _tokenManagerService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(UserManager<ApplicationUser> userManager, UsersContext context, RoleManager<IdentityRole> roleManager, ITokenManagerService tokenManagerService, ILogger<AuthController> logger)
    {
        _userManager = userManager;
        _context = context;
        _roleManager = roleManager;
        _tokenManagerService = tokenManagerService;
        _logger = logger;
    }

    [Route("/Register")]
    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
    {
        var user = new ApplicationUser()
        {
            UserName = request.Username,
            Email = request.Email
        };

        



        //if (user.Email.Contains("petshop.org"))
        //{
        //    var role = await _roleManager.FindByNameAsync(IdentityData.Admin);
        //    if (role == null)
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(IdentityData.Admin));
        //    }
        //    await _userManager.AddToRoleAsync(user, IdentityData.Admin);
        //}
        //else
        //{
        //    var role = await _roleManager.FindByNameAsync(IdentityData.User);
        //    if (role == null)
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(IdentityData.User));
        //    }
        //    await _userManager.AddToRoleAsync(user, IdentityData.User);
        //}


        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        var tracker = _context.ChangeTracker.Entries<ApplicationUser>();

        foreach (var entry in tracker)
        {
             var entity = entry.Entity;
             var state = entry.State;
            await Console.Out.WriteLineAsync(entity.Email);
            await Console.Out.WriteLineAsync(state.ToString());
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

        var auth = _tokenManagerService.CreateToken(userInDb);

        userInDb.RefreshToken = _tokenManagerService.RefreshToken();

        userInDb.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

        _logger.Log(LogLevel.Information, $"{userInDb.UserName}");


        auth.RefreshToken = userInDb.RefreshToken;

        await _userManager.UpdateAsync(userInDb);

        return Ok(auth);
    }

    [Route("/RefreshToken")]
    [HttpPost]
    public async Task<IActionResult> RefreshToken([FromBody] TokenModel request)
    {
        if (request is null)
            return BadRequest("Invalid client request");

        var principal = _tokenManagerService.GetPrincipalFromExpiredToken(request.Token);


        if (principal == null)
            return BadRequest("Invalid client request");
            
        var email = principal.Claims.First(x => x.Type == ClaimTypes.Email);

        
        var user = await _userManager.FindByEmailAsync(email.Value);

        if (user == null || user.RefreshToken != request.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
        {
            return BadRequest("Invalid access token or refresh token");
        }

        var response = _tokenManagerService.CreateToken(user);
        response.RefreshToken = _tokenManagerService.RefreshToken();


        user.RefreshToken = response.RefreshToken;
        await _userManager.UpdateAsync(user);


        return Ok(response);
    }
}
