using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnhancedInvoiceForm
{
    public partial class frmEnhancedInvoiceTotal : Form
    {
        public frmEnhancedInvoiceTotal()
        {
            InitializeComponent();
        }

        private void txtTotalOfInvoices_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal enterSubtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
                    decimal discountPercent = .25m;
                    decimal discountAmount = Math.Round(enterSubtotal * discountPercent, 2);
                    decimal invoiceTotal = enterSubtotal - discountAmount;

                    txtSubtotal.Text = enterSubtotal.ToString("c");
                    txtDiscountPercent.Text = discountPercent.ToString("p1");
                    txtDiscountAmount.Text = discountAmount.ToString("c");
                    txtTotal.Text = invoiceTotal.ToString("c");

                    numberOfInvoices++;
                    totalOfInvoices += invoiceTotal;
                    invoiceAverage = totalOfInvoices / numberOfInvoices;
                    txtNumberOfInvoices.Text = numberOfInvoices.ToString();
                    txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                    txtInvoiceAverage.Text = invoiceAverage.ToString("c");
                    txtEnterSubtotal.Text = "";
                    txtEnterSubtotal.Focus();
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
            IsPresent(txtEnterSubtotal, "Subtotal") &&
            IsDecimal(txtEnterSubtotal, "Subtotal") &&
            IsWithinRange(txtEnterSubtotal, "Subtotal", 1, 10000);

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

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0; 
            totalOfInvoices = 0m; 
            invoiceAverage = 0m;

            txtSubtotal.Text = "";
            txtDiscountPercent.Text = "";
            txtDiscountAmount.Text = "";
            txtTotal.Text = "";

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";
            
            txtEnterSubtotal.Focus(); 
        }

        private void txtNumberOfInvoices_TextChanged(object sender, EventArgs e)
        {

        }

        }
}

