using System.Net;

public class WebApiService
{
    public static void ReturnJson(HttpListenerContext context, string? json)
    {
        if (json != null)
        {
            try
            {
                context.Response.StatusCode = 200;
                context.Response.ContentType = "application/json";
                context.Response.ContentEncoding = System.Text.Encoding.UTF8;
                context.Response.ContentLength64 = json.Length;
                context.Response.OutputStream.Write(System.Text.Encoding.UTF8.GetBytes(json));
                context.Response.OutputStream.Close();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        throw new NullReferenceException("Json is null");
    }
}

