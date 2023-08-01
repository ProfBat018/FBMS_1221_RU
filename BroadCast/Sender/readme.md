# Тема урока: Broadcast

### Broadcast - это передача данных `one to all in network`

Как реализовать на С# ? 


```csharp
// Отправка
UdpClient udpClient = new UdpClient();
udpClient.EnableBroadcast = true;
udpClient.Send(new byte[] { 1, 2, 3, 4, 5 }, 5, new IPEndPoint(IPAddress.Broadcast, 11000));

// Прием
UdpClient udpClient = new UdpClient(11000);
IPEndPoint remoteIp = null;
byte[] data = udpClient.Receive(ref remoteIp);
```


#### Вопрос Лалы: В чем разница между Socket и IpEndPoint ?

Socket - это класс, который хранит IpAdress и Port
IpEndPoint - это класс, который хранит IpAdress и Port

У socket есть метод Send и Receive, а у IpEndPoint нету


