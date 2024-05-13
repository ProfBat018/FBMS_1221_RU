using System.Text;
using Microsoft.EntityFrameworkCore;
using RedisExample.Models;

namespace RedisExample.Services;

public class CacheService
{
    private readonly EmployeesQxContext _context;
    private readonly RedisService _redisService;


    public CacheService(RedisService redisService, EmployeesQxContext context)
    {
        _redisService = redisService;
        _context = context;
    }

    public async Task<IEnumerable<T>> GetData<T>(string key) where T: class, ICacheEntity
    {

        var checkRes = await _redisService.CheckKeyAsync(key);

        if (checkRes)
        {
            return await _redisService.RetrieveDataAsync<T>(key);
        }

        return await _context.Set<T>().ToListAsync();
    }

    public async Task<bool> SetData<T>(List<T> data, string key) where T: ICacheEntity
    {
        if (await _redisService.WriteDataAsync(key, data))
        {
            return true;
        }
        return false;
    }
}