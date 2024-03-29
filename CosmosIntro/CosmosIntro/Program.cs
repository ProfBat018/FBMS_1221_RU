using System.Threading.Channels;
using Azure.Identity;
using CosmosIntro.Data.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

var endpoint = Environment.GetEnvironmentVariable("COSMOS_ENDPOINT");
var key = Environment.GetEnvironmentVariable("COSMOS_KEY");

CosmosClient client = new(
    accountEndpoint: endpoint,
    authKeyOrResourceToken: key
);

var db = client.GetDatabase("SampleDB");
var container = db.GetContainer("SampleContainer");

var query = new QueryDefinition(
    query: "SELECT * FROM c"
);

using FeedIterator<Item> feed = container.GetItemQueryIterator<Item>(
    queryDefinition: query
);


while (feed.HasMoreResults)
{
    FeedResponse<Item> response = await feed.ReadNextAsync();
    foreach (Item item in response)
    {
        Console.WriteLine(item.name);
    }
}


// List<Item> items = new();
// double requestCharge = 0d;
// while (feed.HasMoreResults)
// {
//      FeedResponse<Item> response = await feed.ReadNextAsync();
//      foreach (Item item in response)
//      {
//           items.Add(item);
//      }
//      requestCharge += response.RequestCharge;
// }