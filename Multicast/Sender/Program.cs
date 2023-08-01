using System.Net;
using System.Net.Sockets;
using System.Text;

var port = 12001;
var address = IPAddress.Parse("224.0.0.1");

while (true)
{
    Console.Write("Enter your message: ");
    var message = Console.ReadLine();
    Send(message);
}

void Send(string message)
{
    var sender = new UdpClient();

    var endpoint = new IPEndPoint(address, port);

    var data = Encoding.ASCII.GetBytes(message);
    sender.Send(data, data.Length, endpoint);
}