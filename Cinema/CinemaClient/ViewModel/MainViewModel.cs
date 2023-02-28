using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CinemaClient.Messages;
using System.Net.Sockets;

namespace CinemaClient.ViewModel;
class MainViewModel : ViewModelBase
{
    private ViewModelBase _currentViewModel;
    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            Set(ref _currentViewModel, value);
        }
    }

    private readonly IMessenger _messenger;

    public void ReceiveMessage(NavigationMessage message)
    {
        CurrentViewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
    }

    public MainViewModel(IMessenger messenger)
    {
        CurrentViewModel = App.Container.GetInstance<AuthViewModel>();

        _messenger = messenger;

        _messenger.Register<NavigationMessage>(this, ReceiveMessage);
    }
}

#region MyRelayCommand

/* class MyRelayCommand : ICommand
 {
     public event EventHandler? CanExecuteChanged;

     private readonly Action _action;
     public MyRelayCommand(Action action)
     {
         _action = action;
     }

     public bool CanExecute(object? parameter)
     {
         return true;
     }

     public void Execute(object? parameter)
     {
         _action();
     }
 }


 class MainViewModel
 {
     public MyRelayCommand LoginCommand
     {
         get => new(() =>
         {
             MessageBox.Show("My relay command");
         });
     }
 }*/
#endregion
