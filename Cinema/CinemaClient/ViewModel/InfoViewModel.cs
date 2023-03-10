using CinemaClient.Messages;
using CinemaClient.Model;
using CinemaClient.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaClient.ViewModel
{
    class InfoViewModel : ViewModelBase
    {
        public MovieInfoModel Movie { get; set; } = new();

        private readonly IMessenger _messenger;

        public InfoViewModel(IMessenger messenger)
        {
            _messenger = messenger;

            _messenger.Register<DataMessage>(this, message =>
            {
                Movie = message.Data as MovieInfoModel;
            });
        }
    }
}
