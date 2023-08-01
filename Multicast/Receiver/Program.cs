using System.Net;
using System.Net.Sockets;
using System.Text;

var senderPort = 12001;
var address = IPAddress.Parse("224.0.0.1");

void Receive()
{
    var receiver = new UdpClient(senderPort);
    // JoinMulticastGroup is required to receive multicast messages
    
    // TimeToLive - это TTL пакета, который отправляется при подключении к группе.
    // По умолчанию 1, что означает, что пакеты не будут пересылаться маршрутизаторами.
    // В данном случае, если хотим, чтобы пакеты пересылались, то нужно увеличить TTL
    
    
    /*
        TTL также используется в провайдерах мобильного интернета. Например вы взяли безлимит от Bakcell на час
        но вы не можете им поделится с другом, потому что у вас TTL на телефоне 64, и у друга 64. Но провайдер
        установил TTL на 63, и поэтому вы не можете поделится интернетом с другом.
        
        Простыми словами, TTL - это количество прыжков, которое может сделать пакет, прежде чем он будет отброшен. 
    */
    receiver.JoinMulticastGroup(address, 20); 


    while (true)
    {
        IPEndPoint receiverEP = new(IPAddress.Any, senderPort);

        var result = receiver.Receive(ref receiverEP);
        var receivedData = Encoding.ASCII.GetString(result);
        Console.WriteLine(receivedData);
    }
}


Receive();
