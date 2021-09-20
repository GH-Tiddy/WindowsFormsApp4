using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class PopupAddPerson : Form
    {
        Person person;

        public PopupAddPerson()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            person = new Person(emailTextBox.Text, nameTextBox.Text, companyTextBox.Text, costTextBox.Text);
            MessageBox.Show("Person Added", "Confirmed");
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Person getPerson()
        {
            return person;
        }
    }
}
