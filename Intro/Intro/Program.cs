using System.Net;
using System.Text;
using System.Text.Json;

// Сам по себе WebClient уже устарел, но в простых примерах
// его можно использовать. 

// WebClient client = new();
//
// string json = await client.DownloadStringTaskAsync("https://catfact.ninja/fact");
// Console.WriteLine(json);


HttpClient client = new();

client.BaseAddress = new Uri("https://localhost:7270/People/");

// // GET
// HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
//
// if(response.StatusCode == HttpStatusCode.OK)
// {
//  Console.WriteLine(await response.Content.ReadAsStringAsync());
// }



//// POST

HttpRequestMessage message = new();

message.Method = HttpMethod.Post;
message.RequestUri = client.BaseAddress;
message.Content = new StringContent(
    JsonSerializer.Serialize(new 
    {
        Name = "Maga",
        Surname = "Babayev",
        BirthDate = new DateTime(2006, 10, 17)
    }),
    Encoding.UTF8,
    "application/json"
);

HttpResponseMessage response = await client.SendAsync(message);

if (response.IsSuccessStatusCode)
{
    Console.WriteLine(await response.Content.ReadAsStringAsync());
}

