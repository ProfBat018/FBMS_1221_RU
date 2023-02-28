using CinemaClient.Model;
using CinemaClient.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.ViewModel;
internal class RegisterViewModel : ViewModelBase
{
    public User UserInfo { get; set; } = new();

    private readonly INavigationService _navigationService;

    public RegisterViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }


    public RelayCommand LoginCommand
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<AuthViewModel>();
            });
    }

    public RelayCommand RegisterCommand
    {
        get => new(
            () =>
        {

        });
    }
}
