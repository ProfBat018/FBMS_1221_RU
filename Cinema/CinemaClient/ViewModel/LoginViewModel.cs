using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaClient.ViewModel
{
    internal class LoginViewModel : ViewModelBase
    {
        public IMessenger Messenger { get; set; } = new Messenger();

        public RelayCommand LoginCommand
        {
            get => new(() =>
            {
                MessageBox.Show("Login");
            });
        }

        public RelayCommand RegisterCommand
        {
            get => new(() =>
            {
                Messenger.Send(typeof(RegisterViewModel));
            });
        }
    }
}
