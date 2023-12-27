using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;
using ApiLayer.Services.Redis.Interfaces;
using Newtonsoft.Json;
using StackExchange.Redis;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace PetStoreApi.Services.Redis;

public class CacheService(IDistributedCache redisCache) : ICacheService
{
    private readonly IDistributedCache _redisCache = redisCache;
    
    public async Task<T?> GetDataAsync<T>(string key)
    {
        var value = await _redisCache.GetStringAsync(key);

        if (value == null)
        {
            return default(T);
        }
        
        using MemoryStream ms = new(Encoding.UTF8.GetBytes(value));
        
        return await JsonSerializer.DeserializeAsync<T>(ms) ?? default(T);
    }

    public async Task SetDataAsync<T>(string key, T value, DateTimeOffset expirationTime)
    {
        try
        {
            var options = new DistributedCacheEntryOptions()
                .SetAbsoluteExpiration(expirationTime);

            using var ms = new MemoryStream();

            await JsonSerializer.SerializeAsync(ms, value);
            ms.Position = 0; 

            using var reader = new StreamReader(ms);
            var serializedValue = await reader.ReadToEndAsync();

            await _redisCache.SetStringAsync(key, serializedValue, options);
        }
        catch (Exception e)
        {
            throw;
        }
    }


    public async Task RemoveDataAsync(string key)
    {
         await _redisCache.RemoveAsync(key);
    }

    public async Task<bool> IsCachedAsync(string key)
    {
        return await _redisCache.GetAsync(key) != null;
    }
}
