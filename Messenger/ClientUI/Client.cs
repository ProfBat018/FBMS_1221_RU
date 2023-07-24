using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SessionInfo;

namespace ClientUI;

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

    public async Task SendMessageAsync(string? message)
    {
        if (message == null)
        {
            throw new ArgumentException("Message cannot be null");
        }

        byte[] buffer = Encoding.UTF8.GetBytes(message);   
        await _socket.SendAsync(buffer);
        byte[] bytes = new byte[2048];
    }

    public async Task<MessageInfo> ReceiveMessageAsync()
    {
        byte[] bytes = new byte[2048];
        await _socket.ReceiveAsync(bytes);
        string json = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

        MessageInfo? messageInfo = JsonSerializer.Deserialize<MessageInfo>(json);
        
        _socket.Shutdown(SocketShutdown.Send);
        _socket.Close();
        
        return messageInfo;
    }
    
    public void Dispose()
    {
        _socket.Shutdown(SocketShutdown.Both);   
        _socket.Close();
    }
}