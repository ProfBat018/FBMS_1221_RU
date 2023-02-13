using MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Service.Interfaces
{
    internal interface ISearchService
    {
        public MovieModel SearchByTitle(string? title);
    }
}
