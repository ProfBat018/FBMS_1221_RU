using System.Net;

void ListDirectoryOnFtpServer()
{
    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.1.10.26");
    request.Method = WebRequestMethods.Ftp.ListDirectory;

    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

    StreamReader reader = new StreamReader(response.GetResponseStream());

    Console.WriteLine(reader.ReadToEnd());
}

void DownloadFileFromFtpServer()
{
    ListDirectoryOnFtpServer();

    Console.WriteLine("Enter file name to download: ");
    string fileName = Console.ReadLine();
    
    FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://10.1.10.26/{fileName}");

    request.Method = WebRequestMethods.Ftp.DownloadFile;

    using FtpWebResponse response = (FtpWebResponse)request.GetResponse();
    using Stream stream = response.GetResponseStream();
    using FileStream fileStream = new FileStream(fileName, FileMode.Create); stream.CopyTo(fileStream);

}


DownloadFileFromFtpServer();