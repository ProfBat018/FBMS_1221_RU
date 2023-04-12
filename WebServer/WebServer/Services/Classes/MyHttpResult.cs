using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebServer.Services.Interfaces;

namespace WebServer.Services.Classes
{
    public class MyHttpResult : IActionResult
    {
        public void ExecuteResult(HttpListenerContext? context)
        {
            var result = context!.Response.StatusCode.ToString();

            var bytes = Encoding.UTF8.GetBytes(result);

            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }
    }
}
