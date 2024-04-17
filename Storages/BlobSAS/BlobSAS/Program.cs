#region Get

/*
using System.Net;
using System.Text;

UploadFileToAzureBlobStorage("Maqa xorosho poet", "maqa.txt");

void UploadFileToAzureBlobStorage(string content, string fileName)
{
    string sasToken = "sp=r&st=2024-04-01T16:13:43Z&se=2024-04-02T00:13:43Z&sv=2022-11-02&sr=c&sig=ezzYItegXc%2FstcQQkXxjDsoSzdFzBkZRvutXczaE4Go%3D";
    string storageAccount = "1221storageacc";
    string containerName = "data";
    string blobName = fileName;

    string method = "GET";
    string sampleContent = content;
    int contentLength = Encoding.UTF8.GetByteCount(sampleContent);

    // https://1221storageacc.blob.core.windows.net/data?sp=r&st=2024-04-01T16:13:43Z&se=2024-04-02T00:13:43Z&sv=2022-11-02&sr=c&sig=ezzYItegXc%2FstcQQkXxjDsoSzdFzBkZRvutXczaE4Go%3D
    string requestUri = $"https://{storageAccount}.blob.core.windows.net/{containerName}/{blobName}?{sasToken}";

    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUri);

    request.Method = method;
    request.ContentType = "text/plain; charset=UTF-8";
    request.ContentLength = contentLength;
    request.Headers.Add("x-ms-blob-type", "BlockBlob");

    using Stream requestStream = request.GetRequestStream();
    using FileStream fs = new(fileName, FileMode.CreateNew);

    byte[] buffer = new byte[1024];

    requestStream.Read(buffer, 0, buffer.Length);
    fs.Write(buffer, 0, buffer.Length);

    using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
    {
        if (resp.StatusCode == HttpStatusCode.OK)
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine($"Fail: {resp.StatusCode}");
        }
    }
}
*/

#endregion

#region Put

using System.Net;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System;
using Azure.Storage.Blobs;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;


// await DownloadFileFromAzureBlobStorage("6a0b82810dfeae5c2d2805da1d0b1247.jpg");
await GetBlobAsync();


async Task DownloadFileFromAzureBlobStorage(string fileName)
{
    string connectionString =
         "DefaultEndpointsProtocol=https;AccountName=1221storageacc;AccountKey=OWnOzc1LFVO9JkDaP7aFkcjK/48E1xVhvhkhmwvQ6Ut1wV/7UCnDY2QCiRw0a873/znvDmeA52+o+ASt5HtHTg==;EndpointSuffix=core.windows.net";
     string storageAccount = "1221storageacc";
     string containerName = "images";
     
     
     CloudStorageAccount account = CloudStorageAccount.Parse(connectionString);
     CloudBlobClient blobClient = account.CreateCloudBlobClient();
     CloudBlobContainer container = blobClient.GetContainerReference(containerName);
     
     CloudBlob blob = container.GetBlobReference(fileName);
     
     using var fileStream = System.IO.File.OpenWrite(fileName);
     
     await blob.DownloadToStreamAsync(fileStream);
     
}

async Task GetBlobAsync()
{
    string connectionString =
        "DefaultEndpointsProtocol=https;AccountName=1221storageacc;AccountKey=OWnOzc1LFVO9JkDaP7aFkcjK/48E1xVhvhkhmwvQ6Ut1wV/7UCnDY2QCiRw0a873/znvDmeA52+o+ASt5HtHTg==;EndpointSuffix=core.windows.net";
    string storageAccount = "1221storageacc";
    string containerName = "images";
    
    BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
    BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
    var blobs = containerClient.GetBlobs();

    foreach (var item in blobs){
        Console.WriteLine(item.Name);
    }

}

// async Task DownloadFileFromAzureBlobStorage(string fileName)
// {
//     string connectionString =
//         "DefaultEndpointsProtocol=https;AccountName=1221storageacc;AccountKey=OWnOzc1LFVO9JkDaP7aFkcjK/48E1xVhvhkhmwvQ6Ut1wV/7UCnDY2QCiRw0a873/znvDmeA52+o+ASt5HtHTg==;EndpointSuffix=core.windows.net";
//     string sasToken =
//         "sp=r&st=2024-04-01T16:13:43Z&se=2024-04-02T00:13:43Z&sv=2022-11-02&sr=c&sig=ezzYItegXc%2FstcQQkXxjDsoSzdFzBkZRvutXczaE4Go%3D";
//     string storageAccount = "1221storageacc";
//     string containerName = "images";
//     string blobName = fileName;
//     
//     string requestUri = $"https://{storageAccount}.blob.core.windows.net/{containerName}/{blobName}?{connectionString}";
//
//     using var httpClient = new HttpClient();
//
//     using var stream = await httpClient.GetStreamAsync(requestUri);
//
//     using var downloadedFileStream = new FileStream(fileName, FileMode.Create);
//
//     await stream.CopyToAsync(downloadedFileStream);
//
//     Console.WriteLine("File downloaded successfully.");
// }

#endregion