using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculation
{
    public partial class frmDateHandling : Form
    {
        public frmDateHandling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculateDueDate_Click(object sender, EventArgs e)
        {
            DateTime futureDate = Convert.ToDateTime(txtEnterFutureDate.Text);
            DateTime currentDate = DateTime.Today;

            TimeSpan dueDateTimeSpan = futureDate.Subtract(currentDate);

            MessageBox.Show(dueDateTimeSpan.ToString());
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            DateTime birthDate = Convert.ToDateTime(txtEnterBirthDate.Text);
            int birthYear = birthDate.Year;
            int birthDayOfYear = birthDate.DayOfYear;
            int currentYear = DateTime.Now.Year;
            int currentDayOfYear = DateTime.Now.DayOfYear;

            int age = currentYear - birthYear;

            if (currentDayOfYear < birthDayOfYear)
            {
                age--;
            }
            
            MessageBox.Show(age.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
