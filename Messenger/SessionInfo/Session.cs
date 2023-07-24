using System.Net;
using System.Net.Sockets;

namespace SessionInfo;

public class Session
{
    public List<IPEndPoint> EndPoints { get; set; }
}