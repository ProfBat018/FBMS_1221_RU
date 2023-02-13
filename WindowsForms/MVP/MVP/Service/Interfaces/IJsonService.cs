using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Service.Interfaces
{
    internal interface IJsonService
    {
        public string? GetJsonByTitle(string? title);
    }
}
