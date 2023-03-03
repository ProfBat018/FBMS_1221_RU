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
using System.Windows.Controls;

namespace CinemaClient.ViewModel;

public class AuthViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IUserManageService _userManageService;
    public string Username { get; set; }

    public AuthViewModel(INavigationService navigationService, IUserManageService userManageService)
    {
        _navigationService = navigationService;
        _userManageService = userManageService;
    }

    public RelayCommand<object> LoginCommand
    {
        get => new(
            param =>
        {
            try
            {
                var password = param as PasswordBox;

                var user = _userManageService.GetUser(Username, password.Password);

                MessageBox.Show($"{user.Email} logged in");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User doesn't exist");
            }
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
