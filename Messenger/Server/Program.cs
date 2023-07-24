using System.Net;
using System.Net.Sockets;
using System.Text;
using Server;

var server = new TcpServer(IPAddress.Parse("10.1.10.26"), 11000);

try
{
    await server.ListenAsync();
 
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}