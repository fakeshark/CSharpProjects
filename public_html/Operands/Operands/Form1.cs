using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operands
{
    public partial class frmOperands : Form
    {
        decimal operand1 = 0;
        decimal operand2 = 0;
        decimal result = 0;  


        public frmOperands()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
                string oper = txtOperator.Text;

            try
            {

                operand1 = Convert.ToDecimal(txtOperand1.Text);
                oper = txtOperator.Text;
                operand2 = Convert.ToDecimal(txtOperand2.Text);

            }
            catch(Exception)
            {
                MessageBox.Show("Invalid entry!","Invalid Input");
            }

            switch(oper)
            {
                case "+":
                    result = (operand1 + operand2);
                    break;

                case "-":
                    result = (operand1 - operand2);
                    break;

                case "*":
                    result = (operand1 * operand2);
                    break;

                case "/":
                    result = (operand1 / operand2);
                    break;
            }

            txtResult.Text = result.ToString();

        }
    }
}
