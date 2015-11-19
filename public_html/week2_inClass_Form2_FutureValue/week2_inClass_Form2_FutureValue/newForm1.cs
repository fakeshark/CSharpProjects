using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2_inClass_Form2_FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

private void btnCalculate_Click(object sender, System.EventArgs e)
{
    try 
    { 
        if (IsValidData())
        {
            decimal monthlyInvestment = 
                Convert.ToDecimal(txtMonthlyInvestment.Text); 
            decimal yearlylnterestRate = 
                Convert.ToDecimal(txtInterestRate.Text); 
            int years = 
                Convert.ToInt32(txtYears.Text);

            int months = years * 12; 
            decimal monthlylnterestRate = yearlylnterestRate / 12 / 100;  

            decimal futureValue = CalculateFutureValue(monthlyInvestment, monthlylnterestRate, months); 

            txtFutureValue.Text = futureValue.ToString("c"); 
            txtMonthlyInvestment.Focus(); 
        }
    }

    catch(Exception ex) 
    {
            MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
    } 
}

public bool IsValidData()
{
    return
        IsPresent (txtMonthlyInvestment, "Monthly Investment") &&
        IsDecimal (txtMonthlyInvestment, "Monthly Investment") &&
        IsWithinRange (txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

        IsPresent (txtInterestRate, "Yearly Interest Rate") &&
        IsDecimal (txtInterestRate, "Yearly Interest Rate") &&
        IsWithinRange (txtInterestRate, "Yearly Interest Rate", 1, 20) &&

        IsPresent (txtYears, "Number of Years") &&
        IsInt32 (txtYears, "Number of Years") &&
        IsWithinRange (txtYears, "Number of Years", 1, 40);
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
    catch(FormatException) 
    { 
        MessageBox.Show(name + " must be a decimal value.", "Entry Error");
        textBox.Focus(); 
        return false; 
    }
}

public bool IsInt32(TextBox textBox, string name)
{
    try 
    {
        Convert.ToInt32(textBox.Text); 
        return true; 
    }
    catch(FormatException)
    {
        MessageBox.Show(name + " must be an integer.", "Entry Error"); 
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

private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlylnterestRate, int months) 

{ 
    decimal futureValue = 0m; 
    for (int i = 0; i < months; i++) 
    { 
    futureValue = (futureValue + monthlyInvestment) * (1 + monthlylnterestRate); 
    }
    return futureValue;
}

private void btnExit_Click(object sender, EventArgs e)
    {
    this.Close();
    }
  }  

}
