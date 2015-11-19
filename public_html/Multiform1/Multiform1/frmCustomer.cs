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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        bool isDataSaved = true;

        private void frmCustomer_Load(object sender, System.EventArgs e) 
        { 
            cbxCustomerName.Items.Add("Mike Smith"); 
            cbxCustomerName.Items.Add("Nancy Jones"); 
        }

        private void DataChanged(object sender, System.EventArgs e)
        {
            isDataSaved = false;
        }

        private void btnSelectPayment_Click(object sender, System.EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                lblPaymentBox.Text = (string)paymentForm.Tag;
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
                {
                    SaveData(); 
                }
        }

        private void SaveData()
        {
            cbxCustomerName.SelectedIndex = -1;
            lblPaymentBox.Text = "Data has been saved.";
            isDataSaved = true;
            cbxCustomerName.Focus();
        }

        private bool IsValidData()
        {
            if (cbxCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer.", "Entry Error");
                cbxCustomerName.Focus();
                return false;
            }
            if (lblPaymentBox.Text == "")
            {
                MessageBox.Show("You must enter a payment.", "Entry Error");
                return false;
            }
            return true;
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataSaved == false)
            {
                string message =   "This form contains unsaved data.\n\n" +
                                   "Do you want to save it? ";
                DialogResult button =
                    MessageBox.Show(message, "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                        this.SaveData();
                    else
                        e.Cancel = true;
                }
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
