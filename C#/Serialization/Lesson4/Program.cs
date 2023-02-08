using System.Text.Json;

using FileStream fs = new("json1.json", FileMode.Open);
using StreamReader sr = new(fs);

Sound[] SoundRes = JsonSerializer.Deserialize<Sound[]>(sr.ReadToEnd());

Console.WriteLine(SoundRes[0].url);



