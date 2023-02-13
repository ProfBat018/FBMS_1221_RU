using MVP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MVP.Service.Classes
{
    internal class DeserializeService : IDeserializeService
    {
        public T Deserialize<T>(string? json)
        {
            if (json != null)
            {
                try
                {
                    return JsonSerializer.Deserialize<T>(json);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            throw new ArgumentNullException("Json is  null!!!");
        }
    }
}
