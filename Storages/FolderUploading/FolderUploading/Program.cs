using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string[] students =
[
    "Maqa",
    "Fatima",
    "Rafiq",
    "Farkhad",
    "Jamal",
    "Murad",
    "Sahib",
    "Akbar"
];

string connectionString =
    "DefaultEndpointsProtocol=https;AccountName=1221storageacc;AccountKey=OWnOzc1LFVO9JkDaP7aFkcjK/48E1xVhvhkhmwvQ6Ut1wV/7UCnDY2QCiRw0a873/znvDmeA52+o+ASt5HtHTg==;EndpointSuffix=core.windows.net";
string storageAccount = "1221storageacc";
string containerName = "practice";
string fileName = "readme.md";


var myBlob = File.OpenRead("readme.md");

Console.WriteLine("Opening file...");
foreach (var student in students)
{
    Console.WriteLine($"Creating client for {student}");

    var blobContainerClient = new BlobContainerClient(connectionString, containerName);

    var blob = blobContainerClient.GetBlobClient($"{student}/{fileName}");

    await blob.UploadAsync(myBlob);

    myBlob.Position = 0;
    Console.WriteLine("File uploaded");
}