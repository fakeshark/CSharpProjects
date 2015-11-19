using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class frmFactorials : Form
    {
        public frmFactorials()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumber.Text);
            int factorial = 1;
            for (int i = 1; i < num+1; i++)
            {
                factorial = factorial * i;
            }

            txtFactorial.Text = Convert.ToString(factorial);

        }
    }
}
