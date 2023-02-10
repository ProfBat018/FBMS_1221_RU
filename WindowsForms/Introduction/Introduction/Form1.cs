using Microsoft.AspNetCore.Http;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace Introduction
{
    public partial class Form1 : Form
    {
        public Person Person { get; set; } = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Regex re = new("^(?<firstchar>(?=[A-Za-z]))((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-](?=[A-Za-z]))|(?<spaces> (?=[A-Za-z])))*$");
            Regex re2 = new("^[1-9][0-9]*");
            
            if (re.IsMatch(nameTextBox.Text) && re.IsMatch(surnameTextBox.Text) && re2.IsMatch(ageTextBox.Text))
            {
                Person.Name = nameTextBox.Text;
                Person.Surname = surnameTextBox.Text;
                Person.Age = Convert.ToInt32(ageTextBox.Text);

                peopleListBox.Items.Add(Person);

                nameTextBox.Text = "";
                surnameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void peopleListBox_DoubleClick(object sender, EventArgs e)
        {
            InfoForm form = new(Person);
            form.ShowDialog();
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.jfif";

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Person.ImagePath = dialog.FileName;
            }
            imgLabel.Text = dialog.FileName;
        }
    }
}