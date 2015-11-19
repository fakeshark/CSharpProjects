using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform1
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lbxCardType.Items.Add("Visa");
            lbxCardType.Items.Add("Mastercard");
            lbxCardType.Items.Add("American Express");
            lbxCardType.SelectedIndex = 0;

            string[] months = {"Select a month...", "January", "February", 
                              "March", "April", "May",
                              "June", "July", "August",
                              "September", "October", "November",
                              "December"};
            foreach (string month in months)
                cbxExpDateMonth.Items.Add(month);
            cbxExpDateMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cbxExpDateYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                cbxExpDateYear.Items.Add(year);
                year++;
            }
            cbxExpDateYear.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            { 
                if (lbxCardType.SelectedIndex == -1) 
                {
                MessageBox.Show("You must select a credit card type", "Entry Error");
                lbxCardType.Focus();
                return false;
                }
                if (txtCardNumber.Text == "")
                { 
                    MessageBox.Show("You must enter a credit card number", "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if (rdoCreditCard.Checked)
                {
                    if (cbxExpDateMonth.SelectedIndex == 0)
                    {
                    MessageBox.Show("You must select a month", "Entry Error");
                    cbxExpDateMonth.Focus();
                    return false;
                    }
                }
                if (cbxExpDateYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year", "Entry Error");
                    cbxExpDateYear.Focus();
                    return false;
                }
            }
        return true;
        }
        private void SaveData()
        {
            string msg = null; 
            if (rdoCreditCard.Checked == true)
            {
                msg += "Charge to credit card." + "\n"; 
                msg += "\n"; 
                msg += "Card type: " + lbxCardType.Text + "\n"; 
                msg += "Card number: " + txtCardNumber.Text + "\n"; 
                msg += "Expiration date: " + cbxExpDateMonth.Text + "/" + cbxExpDateYear.Text + "\n"; 
            }
            else 
            {
                msg += "Send bill to customer." + "\n"; 
                msg += "\n";
            }

            bool isDefaultBilling = chkSetAsDefault.Checked; 
            msg += "Default billing: " + isDefaultBilling; 

            this.Tag = msg; 
            this.DialogResult = DialogResult.OK; 
        } 

        private void Billing_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdoCreditCard.Checked) 
                EnableControls(); 
            else 
                DisableControls();
        }

        private void EnableControls()
        {
            lbxCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cbxExpDateMonth.Enabled = true;
            cbxExpDateYear.Enabled = true;
        }

        private void DisableControls() 
        {
            lbxCardType.Enabled = true; 
            txtCardNumber.Enabled = true;
            cbxExpDateMonth.Enabled = true;
            cbxExpDateYear.Enabled = true; 
        }
 


        }
} 
