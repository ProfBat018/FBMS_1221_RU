using System.Net;
using System.Net.Sockets;
using System.Text;

UdpClient server = new(5005);
// Почему тут порт 0, а не 5005 ?
// Потому что мы не знаем, с какого порта придёт сообщение.
// Поэтому мы указываем 0, чтобы сервер принимал сообщения с любого порта.
IPEndPoint remoteEP = new(IPAddress.Any, 0);

while (true)
{
    byte[] data = server.Receive(ref remoteEP);
    string message = Encoding.ASCII.GetString(data);
    
    Console.WriteLine("Received message: " + message);
    Console.Write("Enter reply: ");
    
    string reply = Console.ReadLine();
    
    byte[] replyData = Encoding.ASCII.GetBytes(reply);
    server.Send(replyData, replyData.Length, remoteEP);
}
