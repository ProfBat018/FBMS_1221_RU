using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        public InfoForm(Person person)
        {
            InitializeComponent();

            nameLabel.Text = person.Name;
            surnameLabel.Text = person.Surname;
            ageLabel.Text = person.Age.ToString();

            pictureBox.Image = Image.FromFile(person.ImagePath);
        }
    }
}
