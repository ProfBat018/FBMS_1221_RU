using Cosmos.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace Cosmos.Services;


public class CosmosService : ICosmosService
{
    private readonly CosmosClient _client;

    private Container container
    {
        get => _client.GetDatabase("cosmicworks").GetContainer("products");
    }

    public CosmosService()
    {
        _client = new CosmosClient(
            connectionString: "AccountEndpoint=https://1211cosmos.documents.azure.com:443/;AccountKey=YQhaJeO1ak0c5oJpRhL41uL1SAC1LgHY5koU8PpyID5SxJYWmlqGypH3YIaAoZgD7MZKaHNsfE47ACDbL33iiw==;"
        );
    }

    public async Task<IEnumerable<Product>> RetrieveAllProductsAsync()
    {
        var queryable = container.GetItemLinqQueryable<Product>();

        using FeedIterator<Product> feed = queryable
                                                .Where(p => p.price < 2000m)
                                                .OrderByDescending(p => p.price)
                                                .ToFeedIterator();

        List<Product> results = new();

        while (feed.HasMoreResults)
        {
            foreach (Product item in await feed.ReadNextAsync())
            {
                results.Add(item);
            }
        }
        return results;
    }

    public async Task<IEnumerable<Product>> RetrieveActiveProductsAsync()
    {
        string sql = """
                        SELECT
                            p.id,
                            p.categoryId,
                            p.categoryName,
                            p.sku,
                            p.name,
                            p.description,
                            p.price,
                            p.tags
                        FROM products p
                      """;

        var query = new QueryDefinition(query: sql);

        using FeedIterator<Product> feed = container.GetItemQueryIterator<Product>(queryDefinition: query);

        List<Product> results = new();

        while (feed.HasMoreResults)
        {
            FeedResponse<Product> response = await feed.ReadNextAsync();
            foreach (Product item in response)
            {
                results.Add(item);
            }
        }

        return results;
    }

    public async Task PushActiveProductsAsync()
    {
        var products = new List<Product>()
        {
            new Product(id: "baaa4d2d-5ebe-45fb-9a5c-d06876f408e0", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R72R-60", name: """ML Road Frame - Red, 60""", description: """The product called "ML Road Frame - Red, 60".""", price: 594.83000000000004m),
            new Product(id: "bd43543e-024c-4cda-a852-e29202310214", categoryId: "973B839C-BF5D-485D-9D17-863C59B262E3", categoryName: "Components, Forks", sku: "FK-5136", name: """ML Fork""", description: """The product called "ML Fork".""", price: 175.49000000000001m),
            new Product(id: "2aeceeb7-adb8-4c43-9050-2054420b5a06", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R38R-52", name: """LL Road Frame - Red, 52""", description: """The product called "LL Road Frame - Red, 52".""", price: 337.22000000000003m),
            new Product(id: "e1a27eca-0ec8-48b7-8998-b0971d027280", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R38B-62", name: """LL Road Frame - Black, 62""", description: """The product called "LL Road Frame - Black, 62".""", price: 337.22000000000003m),
            new Product(id: "60dea2b5-63cd-4338-896e-a1eb292e8d3f", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R72Y-38", name: """ML Road Frame-W - Yellow, 38""", description: """The product called "ML Road Frame-W - Yellow, 38".""", price: 594.83000000000004m),
            new Product(id: "ee646dc9-2b52-44de-af51-fce7115848c8", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R72Y-42", name: """ML Road Frame-W - Yellow, 42""", description: """The product called "ML Road Frame-W - Yellow, 42".""", price: 594.83000000000004m),
            new Product(id: "9c76c9f8-4939-4efd-80e0-a69da6901b60", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R92B-52", name: """HL Road Frame - Black, 52""", description: """The product called "HL Road Frame - Black, 52".""", price: 1431.5m),
            new Product(id: "444b580c-81fb-4b2d-9537-1368ccfba6ec", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R92B-44", name: """HL Road Frame - Black, 44""", description: """The product called "HL Road Frame - Black, 44".""", price: 1431.5m),
            new Product(id: "7c434cca-51af-4f30-b37e-9cb6920ef548", categoryId: "3E4CEACD-D007-46EB-82D7-31F6141752B2", categoryName: "Components, Road Frames", sku: "FR-R38R-44", name: """LL Road Frame - Red, 44""", description: """The product called "LL Road Frame - Red, 44".""", price: 337.22000000000003m),
            new Product(id: "d5928182-0307-4bf9-8624-316b9720c58c", categoryId: "AA5A82D4-914C-4132-8C08-E7B75DCE3428", categoryName: "Components, Cranksets", sku: "CS-6583", name: """ML Crankset""", description: """The product called "ML Crankset".""", price: 256.49000000000001m)
        };

        foreach (Product product in products)
        {
            await container.CreateItemAsync<Product>(item: product, partitionKey: new PartitionKey(product.categoryId));
        }
    }
}