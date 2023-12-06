using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using PetsData.DbContexts;
using PetStoreApi.Models.Identity;

namespace PetStoreApi.Controllers;

[ApiController]
public class ProductsController : ControllerBase
{
    private readonly PetDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ProductsController(PetDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpGet("api/products")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _context.Products.Select(x => x.Name).ToListAsync();

        return Ok(products);
    }



    [Authorize]
    [HttpGet("api/products2")]
    public async Task<IActionResult> GetProducts2()
    {
        var products = await _context.Products.Select(x => x.Name).ToListAsync();

        return Ok(products);
    }


    //[Authorize(Policy = IdentityData.User)]
    //[HttpGet("api/products3")]
    //public async Task<IActionResult> GetProducts3()
    //{
    //    var products = await _context.Products.Select(x => x.Name).ToListAsync();

    //    return Ok(products);
    //}
}
