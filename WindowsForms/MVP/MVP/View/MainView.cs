using MVP.Model;
using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.View
{
    public partial class MainView : Form
    {
        private MoviePresenter presenter;
        public MovieModel Movie { get; set; }

        public MainView()
        {
            InitializeComponent();
            
            presenter = new(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            presenter.Search(searchTextBox.Text);

            listBox1.Items.AddRange(Movie.Search);
        }
    }
}
