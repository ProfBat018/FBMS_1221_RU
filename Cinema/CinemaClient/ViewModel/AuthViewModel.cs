using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaClient.Services.Interfaces;
using System.Windows;
using System.Windows.Navigation;

namespace CinemaClient.ViewModel;

public class AuthViewModel : ViewModelBase
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
