using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using SessionInfo;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Server;

public class TcpServer : IDisposable
{
    private Socket _socket;
    private Socket _senderSocket;
    private IPAddress _address;
    private IPEndPoint _endPoint;
    private uint _port;
    private List<IPEndPoint> _clientsEndPoints = new();
    
    public TcpServer(IPAddress address, uint port)
    {
        _address = address;
        _port = port;
        _endPoint = new(_address, (int)_port);
        _socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public async Task ListenAsync()
    {
        _socket.Bind(_endPoint);
        _socket.Listen(10);

        while (true)
        {
            Socket handler = await _socket.AcceptAsync();
            byte[] bytes = new byte[2048];

            await handler.ReceiveAsync(bytes);
            string data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);


            User userInfo = JsonConvert.DeserializeObject<User>(data);

            IPEndPoint newEndPoint = new(userInfo.ReceiverIp, (int)_port);
            
            IPEndPoint? foundEndpoint = _clientsEndPoints.Find(x => x.Address == userInfo.ReceiverIp);

            if (foundEndpoint == null)
            {
                _clientsEndPoints.Add(newEndPoint);
            }
            
            _senderSocket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _senderSocket.Connect(newEndPoint);
            
            var messageBuffer = Encoding.UTF8.GetBytes(JsonSerializer.Serialize<MessageInfo>(userInfo.Message));
            
            await _senderSocket.SendAsync(messageBuffer);
            
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