using CinemaClient.Model;
using CinemaClient.Services.Classes;
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
using System.Windows;
using System.Windows.Controls;

namespace CinemaClient.ViewModel;
internal class RegisterViewModel : ViewModelBase
{
    public User User { get; set; } = new();
    public List<string> Operators { get; set; } = new()
        {
            "050",
            "070",
            "055",
            "077",
            "099",
            "010"
        };

    private readonly INavigationService _navigationService;
    private readonly IUserManageService _userService;

    public RegisterViewModel(INavigationService navigationService, IUserManageService userService)
    {
        _navigationService = navigationService;
        _userService = userService;
    }

    public RelayCommand LoginCommand
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<AuthViewModel>();
            });
    }

    public RelayCommand<object> RegisterCommand
    {
        get => new(
            param =>
        {
            if (param != null)
            {               object[] res = (object[])param;

                var password = (PasswordBox)res[0];
                var confirm = (PasswordBox)res[1];

                var checker = new PasswordService(password, confirm);

                if (checker.IsMatch() && !_userService.CheckExists(User.Username, password.Password))
                {
                    User.Password = password.Password;
                    User.Confirmation = confirm.Password;

                    _userService.Add(User);
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
        });
    }
}
