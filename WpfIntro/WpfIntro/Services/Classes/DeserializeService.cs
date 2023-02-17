using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfIntro.Services.Interfaces;

namespace WpfIntro.Services.Classes
{
    internal class DeserializeService : IDeserializeService
    {
        public T Deserialize<T>(string json)
        {
            try
            {
                var result = JsonSerializer.Deserialize<T>(json);
                if (result != null)
                {
                    return result;
                }
                throw new NullReferenceException("Data is null !");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
