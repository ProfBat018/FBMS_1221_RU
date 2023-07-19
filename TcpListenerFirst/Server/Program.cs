// У нас есть три варианта того, как сделать общение по TCP

// 1. Обычный TCP сервер
// 2. Сервер с использованием TCPListener
// 3. Сервер с использованием TCPListener и NetworkStream

// Вариант 1. Обычный TCP сервер

using System.Net;
using System.Net.Sockets;
using System.Text;

IPAddress ipAddr = IPAddress.Parse("10.1.10.26");
IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

Socket sListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

try
{
     sListener.Bind(ipEndPoint); // связываю прослушку с конечной точкой
     sListener.Listen(10); // начинаю прослушку. backlog - максимальное количество клиентов, которые могут подключиться к серверу

     while (true)
     {
          Console.WriteLine($"Waiting for a connection from port {ipAddr}");

          Socket handler = sListener.Accept(); // принимаю входящее подключение
          string? data = null;
          byte[] bytes = new byte[1024]; // буфер для получаемых данных

          handler.Receive(bytes); // Receive возвращает количество полученных байтов

          data = Encoding.UTF8.GetString(bytes, 0, bytes.Length); // конвертирую байты в строку

          Console.Write("Received data:" + data + "\n\n");

          var response = Console.ReadLine();
          
          handler.Send(Encoding.UTF8.GetBytes($"Message from server: {response}"));
     }
}
catch (Exception ex)
{
     Console.WriteLine(ex.ToString());
}
finally
{
     sListener.Shutdown(SocketShutdown.Both);
     sListener.Close();
}
