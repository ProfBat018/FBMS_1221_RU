using CinemaClient.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaClient.ViewModel
{
    class TicketsViewModel : ViewModelBase
    {
        public Hall MovieHall { get; set; } = new(6);
    }
}
