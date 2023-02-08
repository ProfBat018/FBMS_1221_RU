namespace Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != String.Empty 
                && 
                surnameTextBox.Text != String.Empty)
            {

            Person person = new()
            {
                Name = nameTextBox.Text,
                SurName = surnameTextBox.Text
            };

            peopleListBox.Items.Add(person);

            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}