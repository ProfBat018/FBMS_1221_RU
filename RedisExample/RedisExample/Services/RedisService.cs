using System.Diagnostics.Tracing;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Caching.Distributed;
using RedisExample.Models;
using StackExchange.Redis;

namespace RedisExample.Services;

public class RedisService
{
    private readonly IDatabase _cache;

    public RedisService(IConnectionMultiplexer muxer)
    {
        _cache = muxer.GetDatabase();
    }

    public async Task<bool> CheckKeyAsync(string key)
    {
        return await _cache.KeyExistsAsync(new RedisKey(key));
    }
    public async Task<IEnumerable<T>> RetrieveDataAsync<T>(string key) where T: ICacheEntity
    {
        var buffer = await _cache.StringGetAsync(key);
        return JsonSerializer.Deserialize<IEnumerable<T>>(buffer);
    }

    
    public async Task<bool> WriteDataAsync<T>(string key, List<T> data) where T : ICacheEntity
    {
        try
        {
            var json =  JsonSerializer.Serialize(data);
            await _cache.StringSetAsync(key, json);
            return true;
        }
        catch (Exception)
        {
            throw;
        }
    }
}