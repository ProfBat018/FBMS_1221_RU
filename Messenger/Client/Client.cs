using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client;

public class TcpClient : IDisposable
{
    private Socket _socket;
    private IPAddress _address;
    private IPEndPoint _endPoint;
    private uint _port;
    
    public TcpClient(IPAddress address, uint port)
    {
        _address = address;
        _port = port;
        _endPoint = new(_address, (int)_port);
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        _socket.Connect(_endPoint);
    }

    public void SendMessage(string? message)
    {
        if (message == null)
        {
            throw new ArgumentException("Message cannot be null");
        }

        byte[] buffer = Encoding.UTF8.GetBytes(message);   
        _socket.Send(buffer);
        byte[] bytes = new byte[2048];
    }

    public void ReceiveMessage()
    {
        byte[] bytes = new byte[2048];
        _socket.Receive(bytes);
        string data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
        Console.WriteLine($"Text received: {data}");
        byte[] message = Encoding.ASCII.GetBytes(data);

        _socket.Send(message);
        _socket.Shutdown(SocketShutdown.Send);
        _socket.Close();
    }
    public void Dispose()
    {
        _socket.Shutdown(SocketShutdown.Both);   
        _socket.Close();
    }
}