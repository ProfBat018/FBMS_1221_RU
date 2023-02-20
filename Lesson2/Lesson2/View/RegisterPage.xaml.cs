using Lesson2.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Text.Json;
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

namespace Lesson2
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public User User { get; set; } = new();
        private AuthService authService = new();
        public List<User> Users { get; set; } = new();
        public RegisterPage()
        {
            InitializeComponent();
        }


        private void WriteData()
        {
            using FileStream fs = new("data.json", FileMode.Truncate);
            using StreamWriter sw = new(fs);

            var json = JsonSerializer.Serialize(Users);
            sw.Write(json);
        }


        private void ReadData()
        {
            using FileStream fs = new("data.json", FileMode.OpenOrCreate);
            using StreamReader sr = new(fs);

            var json = sr.ReadToEnd();

            if (!String.IsNullOrEmpty(json))
            {
                Users = JsonSerializer.Deserialize<List<User>>(json);
            }
            Users.Add(User);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            bool check = authService.CheckRegistration(User);
            if (check)
            {
                ReadData();
                WriteData();
            }
        }
    }
}
