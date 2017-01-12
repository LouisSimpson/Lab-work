using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        Birthdays birthdays;
        public Form1()
        {
            InitializeComponent();
        }

        public void AddPeople()
        {
            birthdays.AddPerson("Pete", "cooke", 2, 11, 1956);
            birthdays.AddPerson("Louis", "Simpson", 11, 6, 1996);
            birthdays.AddPerson("Georgie", "Mason", 27, 6, 1996);
        }

        public void DisplayPerson()
        {
            textBoxFirstName.Text = birthdays.GetPersonsFirstName();
            textBoxLastName.Text = birthdays.GetPersonsLastName();
            textBoxDateOfBirth.Text = birthdays.GetPersonsDateOfBirth();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birthdays = new People.Birthdays();
            AddPeople();

            DisplayPerson();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            birthdays.StepToPreviousPerson();

            DisplayPerson();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            birthdays.StepToNextPerson();

            DisplayPerson();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int days = (int)numericUpDownDays.Value;

            string caption = string.Format("Birthdays in the next {0} days", days);

            string message = birthdays.UpcomingBirthdays(days);

            if (message == "")
            {
                message = "no birthdays found!";
            }

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
