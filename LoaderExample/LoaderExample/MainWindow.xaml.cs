using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Navigation;

namespace LoaderExample
{
    public partial class MainWindow : Window
    {
        private Thread workerThread;
        private List<int> res = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            LoadBtn.IsEnabled = false;

            workerThread = new Thread(DoWork);
            workerThread.Start();
        }

        
        // DoWork не запускается в GUI Thread, поэтому нам нужно использовать Dispatcher.Invoke
        private void DoWork()
        {
            Enumerable.Range(0, 30).ToList().ForEach(x =>
            {
                Dispatcher.Invoke(() =>
                {
                    DataListBox.Items.Add(x);
                    ProgressBar.Value = x;
                });
                
                Thread.Sleep(100);
            });

            try
            {
                ProgressBar.IsEnabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            // Dispatcher.Invoke(() => ProgressBar.IsEnabled = true);
        }
    }
}