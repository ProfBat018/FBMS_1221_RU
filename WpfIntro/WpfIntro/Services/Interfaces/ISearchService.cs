using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntro.Services.Interfaces
{
    internal interface ISearchService
    {
        public IDeserializeService DeserializeService { get; init; }
        public IDataDownloadService DataDownloadService { get; init; }
        public T Search<T>(string title);

    }
}
