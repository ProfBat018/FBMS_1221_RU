 using System.Net;
 using Client;
 using Server;

 // нпстроить потоки
 // сделать мульти чат
 // сделать отдельных клиентов
 // сделать логи
 
 
 using var server = new TcpServer(IPAddress.Parse("10.1.10.26"), 11000);
 using var client2 = new TcpClient(IPAddress.Parse("10.1.10.26"), 11000);
 
 try
 {
     server.Listen();
 }
 catch (Exception ex)
 {
     Console.WriteLine(ex.Message);
 }
