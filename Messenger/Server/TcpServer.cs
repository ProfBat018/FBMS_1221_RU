using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server;

public class TcpServer : IDisposable
{
    private Socket _socket;
    private IPAddress _address;
    private IPEndPoint _endPoint;
    private uint _port;
    
    public TcpServer(IPAddress address, uint port)
    {
        _address = address;
        _port = port;
        _endPoint = new(_address, (int)_port);
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Listen()
    {
        _socket.Bind(_endPoint);
        _socket.Listen(10);

        while (true)
        {
            Socket handler = _socket.Accept();
           
            byte[] bytes = new byte[2048];
            
            int bytesRec = handler.Receive(bytes);
            string data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
            Console.WriteLine($"Text received: {data}");
            byte[] message = Encoding.ASCII.GetBytes(data);

            handler.Send(message);
            handler.Shutdown(SocketShutdown.Send);
            handler.Close();
        }
    }

    public void Dispose()
    {
        _socket.Shutdown(SocketShutdown.Both);   
        _socket.Close();
    }
}