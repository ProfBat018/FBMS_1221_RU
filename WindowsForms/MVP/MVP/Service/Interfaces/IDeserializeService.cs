using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MVP.Service.Interfaces
{
    internal interface IDeserializeService
    {
        public T Deserialize<T>(string? json);
    }
}
