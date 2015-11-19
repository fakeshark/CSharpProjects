using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {
        int addOnAmt        = 0;
        decimal salesTax    = .0775m;
        decimal addOn       = .75m;
        decimal mainCourse  = 6.95m;

        string hamBurgerAddOn   = "Add-on Items:  ( 75¢ ea. )";
        string pizzaAddOn       = "Add-on Items:  ( 50¢ ea. )";
        string saladAddOn       = "Add-on Items:  ( 25¢ ea. )";

        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Brian\\Documents\\!School!\\!!!Csharp\\LunchOrder\\LunchOrder\\img\\burger.bmp");
            gbxAddOnItems.Text = hamBurgerAddOn;
            addOn = .75m;
            mainCourse = 6.95m;
            clearBoxes();
            chkCheckBox1.Text = "Lettuce, Tomato, Onion";
            chkCheckBox2.Text = "Ketchup, Mustard, Mayo";
            chkCheckBox3.Text = "French Fries";
        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Brian\\Documents\\!School!\\!!!Csharp\\LunchOrder\\LunchOrder\\img\\pizza.bmp");
            gbxAddOnItems.Text = pizzaAddOn;
            addOn = .5m;
            mainCourse = 5.95m;
            clearBoxes();
            chkCheckBox1.Text = "Peperoni";
            chkCheckBox2.Text = "Sausage";
            chkCheckBox3.Text = "Olives";
        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Brian\\Documents\\!School!\\!!!Csharp\\LunchOrder\\LunchOrder\\img\\salad.bmp");
            gbxAddOnItems.Text = saladAddOn;
            addOn = .25m;
            mainCourse = 4.95m;
            clearBoxes();
            chkCheckBox1.Text = "Croutons";
            chkCheckBox2.Text = "Bacon Bits";
            chkCheckBox3.Text = "Bread Sticks";
        }

        private void clearBoxes()
        {
            chkCheckBox1.Checked = false;
            chkCheckBox2.Checked = false;
            chkCheckBox3.Checked = false;
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            addOnAmt = 0;

            if (chkCheckBox1.Checked == true )
            {
                addOnAmt+= 1;
            }
            if (chkCheckBox2.Checked == true )
            {
                addOnAmt+= 1;
            }
            if (chkCheckBox3.Checked == true )
            {
                addOnAmt+= 1;
            }

            decimal subTotal    =   (mainCourse + (addOn * addOnAmt));
            decimal salesTaxAmt =   (subTotal * salesTax);
            decimal orderTotal  =   (subTotal + salesTaxAmt);

            txtSubtotal.Text    =   string.Format("{0:c}", subTotal);
            txtSalesTax.Text    =   string.Format("{0:c}", salesTaxAmt);
            txtOrderTotal.Text  =   string.Format("{0:c}", orderTotal);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
