using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetsData.DbContexts;

namespace PetStoreApi.Controllers;

[ApiController]
public class ProductsController : ControllerBase 
{
    private readonly PetDbContext _context;

    public ProductsController(PetDbContext context)
    {
        _context = context;
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
        var products = await _context.Products.ToListAsync();

        return Ok(products);
    }




}
