using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int operand1 = Convert.ToInt32(txtOperand1.Text);
            string mathOperator = (txtOperator.Text);
            int operand2 = Convert.ToInt32(txtOperand2.Text);
            int results = 0;

            if (mathOperator == "+")    {
               results = (operand1 + operand2);
            } else if (mathOperator == "-")     {
               results = (operand1 - operand2);
            } else if (mathOperator == "/")     {
               results = (operand1 / operand2);
            } else {
               results = (operand1 * operand2);
            }

            txtResult.Text = results.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 
           this.Close();
        }
    }
}
