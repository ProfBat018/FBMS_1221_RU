using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfRepeat
{
    internal class MainViewModel : ViewModelBase
    {
        public RelayCommand FirstCommand
        {
            get =>
                new(
                    () =>
                    {
                        var window = new FirstView();
                        window.ShowDialog();
                    }
            );
        }

        public RelayCommand SecondCommand
        {
            get => new(
                () =>
                  {
                      var window = new SecondView();
                      window.ShowDialog();
                  });
        }
    }
}
