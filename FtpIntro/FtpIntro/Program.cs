using System.Net;

var uri = new Uri("ftp://4.180.154.90");

FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(uri);

ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

var response = (FtpWebResponse)ftpRequest.GetResponse();
using var streamReader = new StreamReader(response.GetResponseStream());

var directories = new List<string>();

string line = streamReader.ReadLine();

while (!string.IsNullOrEmpty(line))
{
    directories.Add(line);
    line = streamReader.ReadLine();
}

foreach (var item in directories)
{
    Console.WriteLine(item);
}