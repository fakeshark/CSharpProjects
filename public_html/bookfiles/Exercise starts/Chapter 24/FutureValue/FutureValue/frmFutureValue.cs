using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FutureValue
{
    // This is the starting point for exercise 24-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataIsValid())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal interestRateYearly =
                        Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal interestRateMonthly = interestRateYearly / 12 / 100;
                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, interestRateMonthly, months);

                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        public bool DataIsValid()
        {
            return
                // Validate the Monthly Investment text box
                Validator.IsPresent(txtMonthlyInvestment) &&
                Validator.IsDecimal(txtMonthlyInvestment) &&
                Validator.IsWithinRange(txtMonthlyInvestment, 1, 1000) &&

                // Validate the Yearly Interest Rate text box
                Validator.IsPresent(txtInterestRate) &&
                Validator.IsDecimal(txtInterestRate) &&
                Validator.IsWithinRange(txtInterestRate, 1, 20) &&

                // Validate the Number of Years text box
                Validator.IsPresent(txtYears) &&
                Validator.IsInt32(txtYears) &&
                Validator.IsWithinRange(txtYears, 1, 40);
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal interestRateMonthly, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + interestRateMonthly);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}