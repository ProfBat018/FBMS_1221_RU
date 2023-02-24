using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CinemaClient.Messages;
using CinemaClient.Services.Interfaces;

namespace CinemaClient.ViewModel
{
    internal class AuthViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public AuthViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
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
                _navigationService.NavigateTo<RegisterViewModel>();
            });
        }
    }
}
