using System.Text;

HttpClient client = new();
HttpRequestMessage message = new();


client.BaseAddress = new("https://1221vision.cognitiveservices.azure.com/computervision/retrieval/indexes/my-video-index?api-version=2023-05-01-preview");

message.Headers.Add("Ocp-Apim-Subscription-Key", "89c600e6702146d88b3e1b4397d78e1b");

using FileStream fs = new("indexCrete.json", FileMode.OpenOrCreate);
using StreamReader sr = new(fs);


message.Content = new StringContent(sr.ReadToEnd(), Encoding.ASCII, "application/json");

message.Method = HttpMethod.Put;

var res = await client.SendAsync(message);

var responseMessage = await res.Content.ReadAsStringAsync();

Console.WriteLine(responseMessage);

