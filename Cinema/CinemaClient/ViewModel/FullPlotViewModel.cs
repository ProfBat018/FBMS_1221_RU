using CinemaClient.Messages;
using CinemaClient.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.ViewModel
{
    class FullPlotViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        public MovieInfoModel Info { get; set; } = new();

        public FullPlotViewModel(IMessenger messenger)
        {
            _messenger = messenger;

            _messenger.Register<DataMessage>(this, message =>
            {
                Info = message.Data as MovieInfoModel;
            });
        }

    }
}
