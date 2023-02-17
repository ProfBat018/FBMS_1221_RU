using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfIntro.Model;
using WpfIntro.Services.Classes;
using WpfIntro.Services.Interfaces;

namespace WpfIntro
{
    public partial class MainWindow : Window
    {
        private readonly ISearchService searchService = new SearchService()
        {
            DataDownloadService = new DataDownloadService(),
            DeserializeService = new DeserializeService()
        };

        public ObservableCollection<Search> Movies { get; set; } = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var movies = searchService.Search<MovieModel>(searchBox.Text);
                Movies.Clear();
                foreach (var item in movies.Search)
                {
                    Movies.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
