using Microsoft.Extensions.Caching.Distributed;
using System.Text;
using System.Text.Json;

namespace PetStoreApi.Services.Redis;

public class RedisCacheService(IDistributedCache cache)
{
    private readonly IDistributedCache _cache = cache;

    public async Task<T> GetCachedDataAsync<T>(string key)
    {
        var jsonData = await _cache.GetStringAsync(key);

        if (jsonData is null)
        {
            return default;
        }
        
        using var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonData));

        return await JsonSerializer.DeserializeAsync<T>(ms);
    }
}
