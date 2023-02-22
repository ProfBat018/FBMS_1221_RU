using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CinemaClient.ViewModel
{

    class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; } = new LoginViewModel();

        public MainViewModel()
        {

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

}
