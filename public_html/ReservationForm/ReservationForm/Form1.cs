using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationForm
{
    public partial class frmReservations : Form
    {
        public frmReservations()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    DateTime ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
                    DateTime DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
                    decimal pricePerNight = 115.00m;

                    TimeSpan numberOfNights = DepartureDate - ArrivalDate;
                    decimal totalPrice = (numberOfNights.Days * pricePerNight);

                    txtNumberOfNights.Text = numberOfNights.Days.ToString();
                    txtPricePerNight.Text = pricePerNight.ToString("C");
                    txtTotalPrice.Text = totalPrice.ToString("C");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData()
        {
            return
                IsPresent(txtArrivalDate, "Arrival Date") &&
                IsDate(txtArrivalDate, "Arrival Date") &&
                IsLaterDate(txtArrivalDate, "Arrival Date", DateTime.Today) &&

                IsPresent(txtDepartureDate, "Departure Date") &&
                IsDate(txtDepartureDate, "Departure Date") &&
                Is3DaysLater(txtDepartureDate, "Departure Date", Convert.ToDateTime(txtArrivalDate.Text));
        }

        public bool IsPresent(TextBox textbox, string name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a reqired field.", "Entry Error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDate(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDateTime(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a DateTime value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsLaterDate(TextBox textBox, string name, DateTime today)
        {
            DateTime arrival = Convert.ToDateTime(textBox.Text);
            if (arrival < today)
            {
                MessageBox.Show(name + " must be today '" + today.ToString("MM/dd/yyyy") + "' or later.", "Entry Error");
                txtArrivalDate.Text = today.ToString("MM/dd/yyyy");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool Is3DaysLater(TextBox textBox, string name, DateTime arrival)
        {
            DateTime departure = Convert.ToDateTime(textBox.Text);
            DateTime arrivalDate = arrival;
            if (departure < arrivalDate.AddDays(3))
            {
                MessageBox.Show(name + " must be '" + arrivalDate.AddDays(3).ToString("MM/dd/yyyy") + "' or later.", "Entry Error");
                txtDepartureDate.Text = arrivalDate.AddDays(3).ToString("MM/dd/yyyy");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
