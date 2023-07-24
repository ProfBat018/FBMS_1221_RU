using System.Net;
using Newtonsoft.Json;


namespace SessionInfo;

public class User
{
    [JsonConverter(typeof(IpAddressConverter))]
    public IPAddress ReceiverIp { get; set; }
    public MessageInfo Message { get; set; }
}
