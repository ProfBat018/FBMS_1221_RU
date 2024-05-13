using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.StackExchangeRedis;
using RedisExample;
using RedisExample.Services;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmployeesQxContext>(
    ops => ops.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect("localhost"));

builder.Services.AddTransient<RedisService>();
builder.Services.AddTransient<CacheService>();

var app = builder.Build();

app.MapPost("/addDeptToRedis", async (RedisService _redis, CacheService _cache, EmployeesQxContext _context) =>
{
    var depts = await _context.Depts.ToListAsync();
    await _cache.SetData(depts, "depts");
});

app.MapGet("/getDeptFromRedis", async (RedisService _redis, CacheService _cache) =>
{
    var res = await _cache.GetData<Dept>("depts");
    return res;
});

app.MapGet("/getTest", async () =>
{
    return new { Message = "This is test endpoint", Code=200};
});

app.MapGet("/getDeptFromDb", async (EmployeesQxContext _context) =>
{
    var res = await _context.Depts.ToListAsync();
    return res;
});


    app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();



app.Run();