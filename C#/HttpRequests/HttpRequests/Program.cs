using System.Net;
using System.Text.Json;

HttpClient client = new();

var json = await client.GetStringAsync(@"https://localhost:7252/Admin/Product/GetAll");

var products = JsonSerializer.Deserialize<Products>(json);

Console.WriteLine(products.data[1].title);

