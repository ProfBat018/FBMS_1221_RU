using System.Net;
using System.Net.Sockets;
using System.Text;

UdpClient client = new();
IPEndPoint serverEP = new(IPAddress.Parse("127.0.0.1"), 5005);

while (true)
{
    string message = Console.ReadLine();

    byte[] data = Encoding.ASCII.GetBytes(message);

    client.Send(data, data.Length, serverEP);

    byte[] replyData = client.Receive(ref serverEP);

    string reply = Encoding.ASCII.GetString(replyData);

    Console.WriteLine("Received reply: " + reply);
}