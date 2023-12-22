using ApplicationLayer.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using PetsData.DbContexts;
using PetsData.Models;
using PetStoreApi.Models.Identity;

namespace PetStoreApi.Controllers;



[Authorize]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly PetDbContext _context;
    private readonly IMediator _mediator;

    public ProductsController(PetDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    [AllowAnonymous]
    [HttpGet("api/products")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());

        return Ok(products);
    }

    /*
    
    [AllowAnonymous]
    [HttpGet("api/products")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _context.Products.Select(x => x.Name).ToListAsync();

        return Ok(products);
    }
    

    [HttpGet("api/products2")]
    public async Task<IActionResult> GetProducts2()
    {
        var products = await _context.Products.Select(x => x.Name).ToListAsync();

        return Ok(products);
    }

    */



}
