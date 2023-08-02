using System.Net;
using System.Reflection;

namespace HttpClient;

public class MyHttpWebClient : IDisposable
{
    private uint port;
    private string host;
    private HttpListener _httpListener;

    public MyHttpWebClient(uint port)
    {
        _httpListener = new HttpListener();
        this.port = port;
        this.host = $"http://localhost:{port}/";

        _httpListener.Prefixes.Add(this.host);
        
        this.Start();
    }

    public void Start()
    {
        _httpListener.Start();
        Console.WriteLine($"Listening on {this.host}");
        bool isRunning = true;
        while (isRunning)
        {
            MethodInfo[] methods = typeof(AcademyWebApi).GetMethods();
            HttpListenerContext context = _httpListener.GetContext();

            string url = context.Request.RawUrl; // /GetAllPeople

            foreach (var item in methods)
            {
                if(url == $"/{item.Name}")
                {
                    AcademyWebApi academyWebApi = new AcademyWebApi(context, new AcademyContext(), new WebApiService());
                    item.Invoke(academyWebApi, null);
                    isRunning = false;
                    break;
                }
            }
        }
    }

    public void Stop()
    {
        _httpListener.Stop();
        Console.WriteLine($"Stopped listening on {this.host}");
    }

    public void Dispose()
    {
        this.Stop();
        _httpListener.Close();
    }
}