using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using SessionInfo;

namespace ClientUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TcpClient _client;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectBtn_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _client = new(IPAddress.Parse("10.1.10.26"), 11000);
                ConnectBtn.IsEnabled = false;
                Thread listenThread = new(() =>
                {
                    while (true)
                    {
                        MessageInfo? message = _client.ReceiveMessageAsync().GetAwaiter().GetResult();
                        if (message != null)
                        {
                            Dispatcher.Invoke(() => { MessageListBox.Items.Add(message); });
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void SendBtn_OnClick(object sender, RoutedEventArgs e)
        {
            User userInfo = new()
            {
                ReceiverIp = IPAddress.Parse(IpTextBox.Text),
                Message = new MessageInfo()
                {
                    Username = UsernameTextBox.Text,
                    Date = DateTime.Now,
                    Message = MessageTextBox.Text
                }
            };

            var json = await Task.Run(() => JsonConvert.SerializeObject(userInfo));
    
            await _client.SendMessageAsync(json);
            
            MessageListBox.Items.Add(new MessageInfo()
            {
                Date = DateTime.Now,
                Message = MessageTextBox.Text
            });
        }
    }
}