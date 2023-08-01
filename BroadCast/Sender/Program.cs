using System.Net;
using System.Net.Sockets;
using System.Text;

UdpClient udpClient = new UdpClient();
udpClient.EnableBroadcast = true;

while (true)
{
    Console.Write("Enter a message to broadcast :");
    byte[] data = Encoding.ASCII.GetBytes(Console.ReadLine());
    udpClient.Send(data, data.Length, new IPEndPoint(IPAddress.Broadcast, 11000));
}
