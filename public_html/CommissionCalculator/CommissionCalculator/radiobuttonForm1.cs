using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CommissionCalculator
{

    public partial class frmCommissionCalc : Form
    {
        decimal longevityRate = .01m;
        decimal titleIncentiveRate = 0m;
        public frmCommissionCalc()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalCommission_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleIncentive_Click(object sender, EventArgs e)
        {

        }

        private void lblLongevity_Click(object sender, EventArgs e)
        {

        }

        private void lblBaseComission_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string salesPerson = (txtSalesPerson.Text);
            decimal salesAmount = Convert.ToDecimal(txtSalesAmount.Text);
            //int yearsOfService = Convert.ToInt32(txtYearsOfService.Text);
            //string title = cboxTitle.SelectedIndex.ToString();

            decimal baseCommissionRate = .02m;
            decimal baseCommissionAmount = 0m;
            //decimal longevityRate = 0m;
            decimal longevityAmount = 0m;
            //decimal titleIncentiveRate = 0m;
            decimal titleIncentiveAmount = 0m;
            decimal totalCommissionRate = 0m;
            decimal totalCommissionAmount = 0m;

// Determine Longevity-based percentage

            //if ( yearsOfService >= 0 && yearsOfService < 5 )
            //{
            //    longevityRate = .01m;
            //}
            //else if ( yearsOfService >= 5 && yearsOfService < 10 )
            //{
            //    longevityRate = .02m;
            //}
            //else if ( yearsOfService >= 10 )
            //{
            //    longevityRate = .03m;
            //}

// Determine Title-based percentage

            //if (title == "0") // 0 -> Apprentice selected
            //{
            //    titleIncentiveRate = 0m;
            //}
            //else if (title == "1") // 1 -> Associate selected
            //{
            //    titleIncentiveRate = .01m;
            //}
            //else if (title == "2") // 2 -> Apprentice selected
            //{
            //    titleIncentiveRate = .02m;
            //}

//Calculate rates

            baseCommissionAmount = (salesAmount * baseCommissionRate);
            longevityAmount = (salesAmount * longevityRate);
            titleIncentiveAmount = (salesAmount * titleIncentiveRate);

// Calculate Total Commission rate & percentage

            totalCommissionRate = (baseCommissionRate + longevityRate + titleIncentiveRate);
            totalCommissionAmount = (baseCommissionAmount + longevityAmount + titleIncentiveAmount);

// Output results to form

            txtBaseCommissionRate.Text = (baseCommissionRate * 100) + '%'.ToString();
            txtBaseCommissionAmount.Text = "$" + baseCommissionAmount.ToString("F");

            txtLongevityRate.Text = (longevityRate * 100) + '%'.ToString();
            txtLongevityAmount.Text = "$" + longevityAmount.ToString("F");

            txtTitleIncentiveRate.Text = (titleIncentiveRate * 100) + '%'.ToString();
            txtTitleIncentiveAmount.Text = "$" + titleIncentiveAmount.ToString("F");

            txtTotalCommissionRate.Text = (totalCommissionRate * 100) + '%'.ToString();
            txtTotalCommissionAmount.Text = "$" + totalCommissionAmount.ToString("F");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalesPerson.Clear();
            txtSalesAmount.Clear();
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            txtBaseCommissionRate.Clear();
            txtBaseCommissionAmount.Clear();
            txtLongevityRate.Clear();
            txtLongevityAmount.Clear();
            txtTitleIncentiveRate.Clear();
            txtTitleIncentiveAmount.Clear();
            txtTotalCommissionRate.Clear();
            txtTotalCommissionAmount.Clear();
        }

        private void frmCommissionCalc_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                longevityRate = .01m;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                longevityRate = .02m;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                longevityRate = .03m;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                titleIncentiveRate = 0m;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                titleIncentiveRate = .01m;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                titleIncentiveRate = .02m;
            }
        }
    }
}
