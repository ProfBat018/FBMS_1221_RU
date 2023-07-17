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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using PersonRepo.Data.DbContexts;

namespace LoaderSecond
{
    public partial class MainWindow : Window
    {
        private PeopleDbContext _context = new();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            #region Part1
            /*
            try
            {
                var people = await _context.People.Where(x => x.BirthDate.Year <= 2001).ToListAsync();

                Dispatcher.Invoke(() =>
                {
                    foreach (var item in people)   
                    { 
                        DataListBox.Items.Add(item);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  */         
            #endregion
            
            #region Part2
            /*
            var people = await _context.People.Where(x => x.BirthDate.Year <= 2001).ToListAsync();

            Parallel.ForEach(people, async (item) =>
            {
                await Dispatcher.BeginInvoke(() =>
                {
                    DataListBox.Items.Add(item);
                });
            });
            */
            #endregion
            
            #region Part3
            
            // Parallel LINQ
            var people = _context.People.Where(x => x.BirthDate.Year <= 2001).AsParallel().OrderBy(x => x.Name).ToList();

            people.AsParallel().ForAll(x => x.Name = "Test");
            
            Parallel.ForEach(people, async (item) =>
            {
                await Dispatcher.BeginInvoke(() =>
                {
                    DataListBox.Items.Add(item);
                });
            });
            

            #endregion


        }
    }
}