using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Services.Interfaces
{
    public interface INavigationService
    {
        public void NavigateTo<T>(object? data=null) where T : ViewModelBase;
    }
}
