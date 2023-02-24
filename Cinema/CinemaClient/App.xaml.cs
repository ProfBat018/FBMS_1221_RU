using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using CinemaClient.Services.Classes;
using CinemaClient.Services.Interfaces;
using CinemaClient.View;
using CinemaClient.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;

namespace CinemaClient
{
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e)
        {
           Register();
           MainStartup();
            
            base.OnStartup(e);
        }

        private void Register()
        {
            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<HomeViewModel>();
            Container.RegisterSingleton<AuthViewModel>();
            Container.RegisterSingleton<RegisterViewModel>();
        }

        private void MainStartup()
        {
            var mainView = new MainView();
            mainView.DataContext = Container?.GetInstance<MainViewModel>();
            mainView.ShowDialog();
        }
    }
}
