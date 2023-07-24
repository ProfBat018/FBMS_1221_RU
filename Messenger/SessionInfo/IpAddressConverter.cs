using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SessionInfo;

public class IpAddressConverter : JsonConverter
{   
    
    public override bool CanConvert(Type objectType)
    {
        if (objectType == typeof(IPAddress)) return true;
        if (objectType == typeof(List<IPAddress>)) return true;

        return false;
    }
        
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (objectType == typeof(IPAddress))
        {
            return IPAddress.Parse(JToken.Load(reader).ToString());
        }

        if (objectType == typeof(List<IPAddress>))
        {
            return JToken.Load(reader).Select(address => IPAddress.Parse((string) address)).ToList();
        }

        throw new NotImplementedException();
    }
        
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value.GetType() == typeof(IPAddress))
        {
            JToken.FromObject(value.ToString()).WriteTo(writer);
            return;
        }

        if (value.GetType() == typeof(List<IPAddress>))
        {
            JToken.FromObject((from n in (List<IPAddress>) value select n.ToString()).ToList()).WriteTo(writer);
            return;
        }
            
        throw new NotImplementedException();
    }
}