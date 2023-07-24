// Пример работы обычного TcpListener

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

/*
TcpListener - это обертка над сокетом, которая позволяет прослушивать порт и принимать входящие соединения.
По факту - это тоже самое что я написал на прошлом уроке. Под капотом у него храниться Socket и IpEndPoint.

TcpClient - это тоже обертка над сокетом и позволяет подключаться к серверу. его мы тоже реализовали.
В отличии от TcpListener, TcpClient не может принимать входящие соединения, он может только подключаться к серверу и отправлять данные.

Плюс TcpClient в том, что он не возвращает обычный массив из байтов, а возвращает объект NetworkStream.
*/


var tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
tcpListener.Start();

while (true)
{
    using TcpClient tcpClient = tcpListener.AcceptTcpClient();
    using NetworkStream networkStream = tcpClient.GetStream();

    var buffer = new byte[networkStream.Length];

    var bytesRead = networkStream.Read(buffer, 0, buffer.Length);

    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));

    var response = Encoding.UTF8.GetBytes("Hello from server!");
    networkStream.Write(response, 0, response.Length);
}