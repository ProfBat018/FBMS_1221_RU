using CinemaClient.Messages;
using CinemaClient.Model;
using CinemaClient.Services.Interfaces;
using CinemaClient.View;
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
    class InfoViewModel : ViewModelBase
    {
        public MovieInfoModel Movie { get; set; } = new();

        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;

        public InfoViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;

            _messenger.Register<DataMessage>(this, message =>
            {
                Movie = message.Data as MovieInfoModel;
            });
            _navigationService = navigationService;
        }


        public RelayCommand BackCommand
        {
            get => new(() =>
            {
                _navigationService.NavigateTo<HomeViewModel>();
            });
        }

        public RelayCommand FullPlotCommand
        {
            get => new(() =>
            {
                    var window = new FullPlot();
                    window.Show();
            });
        }

        public RelayCommand BuyCommand
        {
            get => new(() =>
            {
                _navigationService.NavigateTo<TicketsViewModel>();
            });
        }
    }
}
