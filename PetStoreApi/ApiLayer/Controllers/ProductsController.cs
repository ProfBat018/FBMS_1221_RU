using ApiLayer.Services.Redis.Interfaces;
using ApplicationLayer.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
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
    private readonly ICacheService _cacheService;
    public ProductsController(PetDbContext context, IMediator mediator, ICacheService cacheService)
    {
        _context = context;
        _mediator = mediator;
        _cacheService = cacheService;
    }

    [AllowAnonymous]
    [HttpGet("api/products")]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());

        return Ok(products);
    }
    
    [AllowAnonymous]
    [HttpGet("api/productswithredis/")]
    public async Task<IActionResult> GetProductsWithRedis()
    {
        if (await _cacheService.IsCachedAsync("products"))
        {
            return Ok(await _cacheService.GetDataAsync<List<Product>>("products"));
        }
        
        var products = await _mediator.Send(new GetProductsQuery());
        
        await _cacheService.SetDataAsync("products", products, DateTimeOffset.Now.AddMinutes(5));
        
        return Ok(products);
    }
}

