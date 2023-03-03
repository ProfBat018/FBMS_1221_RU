using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Services.Interfaces
{
    public interface ISerializeService
    {
        string Serialize<T>(object obj);
        T Deserialize<T>(string json);
    }
}
