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

// ViewModelBase - базовый класс для ViewModel из MvvmLightLibsStd10
// Зачем нам ViewModelBase ? Для того, чтобы понимать какие классы являются ViewModel мы наследуем его от родителя. 


class MainViewModel : ViewModelBase 
{
    // интерфейс из MvvmLightLibsStd10. Нужен для отправки и принятия сообщения классу
    private readonly IMessenger _messenger; 
    private ViewModelBase _currentViewModel;

    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            Set(ref _currentViewModel, value); // Функция Set() автоматически вызывает PropertyChanged.
        }
    }

    public void ReceiveMessage(NavigationMessage message)
    {
        CurrentViewModel = App.Container.GetInstance(message.ViewModelType) as ViewModelBase;
    }

    public MainViewModel(IMessenger messenger) // constructor
    {
        CurrentViewModel = App.Container.GetInstance<AuthViewModel>(); // Ставлю окно по умолчанию 
        
        _messenger = messenger; 

        // Register - регистрация класса на сообщение какого-то типа 
        // параметр this - говорит о том, кого именно регистрировать.
        // this - это объект MainViewModel созданный SimpleInjector-ом в App.Container
        // ReceiveMessage - Функция, которая запускается после принятия сообщения и принимает в параметрах это сообщение
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
