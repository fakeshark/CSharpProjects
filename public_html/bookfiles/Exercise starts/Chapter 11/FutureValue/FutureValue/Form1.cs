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
    // This is the starting point for exercise 11-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				decimal monthlyInvestment =
					Convert.ToDecimal(txtMonthlyInvestment.Text);
				decimal yearlyInterestRate =
					Convert.ToDecimal(txtInterestRate.Text);
				int years = Convert.ToInt32(txtYears.Text);

				int months = years * 12;
				decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

				decimal futureValue = CalculateFutureValue(
					monthlyInvestment, monthlyInterestRate, months);

                txtFutureValue.Text = futureValue.ToString("p");
                txtMonthlyInvestment.Focus();
		    }
		    catch (Exception ex)
		    {
			    MessageBox.Show(ex.Message + "\n\n" +
				    ex.GetType().ToString() + "\n" +
				    ex.StackTrace, "Exception");
		    }
		}

		private decimal CalculateFutureValue(decimal monthlyInvestment,
			decimal monthlyInterestRate, int months)
		{
			decimal futureValue = 0;
			for (int i = 0; i < months; i++)
			{
				futureValue = (futureValue + monthlyInvestment)
					* (1 + monthlyInterestRate);
			}

			
            return futureValue;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}