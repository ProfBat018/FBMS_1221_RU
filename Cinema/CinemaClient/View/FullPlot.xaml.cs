using CinemaClient.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CinemaClient.View
{
    public partial class FullPlot : Window
    {
        private bool check = false;
        public FullPlot()
        {
            InitializeComponent();
            DataContext = App.Container.GetInstance<FullPlotViewModel>();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            check = true;
            this.Close();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            if (!check)
            {
                this.Close();
            }
        }
    }
}
