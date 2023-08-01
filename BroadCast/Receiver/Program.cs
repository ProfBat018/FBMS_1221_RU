using System.Net;
using System.Net.Sockets;

UdpClient udpClient = new(11000);
IPEndPoint remoteIp = null;

while (true)
{
byte[] data = udpClient.Receive(ref remoteIp);
Console.WriteLine($"Received broadcast from {remoteIp} :");
}
