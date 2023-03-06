using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
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
    public partial class App : Application // Класс App создается автоматически
    {
        public static Container Container { get; set; } = new();

        protected override void OnStartup(StartupEventArgs e) // virtual void OnStartup
        {
            Register();
            MainStartup();
        }

        private void Register()
        {
            // Singleton - это всего одна ссылка объекта во всей программе. 
            // Создаются объекты моих классов и записываются в интерфейсные ссылки

            // IMessenger messenger = new Messenger();
            // При этом messenger один на всю программу. 
            Container.RegisterSingleton<IMessenger, Messenger>(); 

            Container.RegisterSingleton<INavigationService, NavigationService>(); // INavigationService ref1 = new NavigationService();
            Container.RegisterSingleton<ISerializeService, SerializeService>();
            Container.RegisterSingleton<IUserManageService, UserManageService>();


            Container.RegisterSingleton<MainViewModel>(); // Создаются объекты моих классов
            Container.RegisterSingleton<HomeViewModel>();
            Container.RegisterSingleton<AuthViewModel>();
            Container.RegisterSingleton<RegisterViewModel>();
        }

        private void MainStartup()
        {
            var mainView = new MainView();
            mainView.DataContext = Container.GetInstance<MainViewModel>();
            mainView.ShowDialog();
        }
    }
}
