using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinancialCalculations
{
    // This is the solution to exercise 24-2 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void mnuNewFutureValue_Click(object sender, System.EventArgs e)
		{
			Form newForm = new frmFutureValue();
			newForm.MdiParent = this;
			newForm.Show();
		}

		private void mnuNewDepreciation_Click(object sender, System.EventArgs e)
		{
			Form newForm = new frmDepreciation();
			newForm.MdiParent = this;
			newForm.Show();
		}

		private void mnuClose_Click(object sender, System.EventArgs e)
		{
			Form activeForm = this.ActiveMdiChild;
			if (activeForm != null)
				activeForm.Close();
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void mnuToolbar_Click(object sender, EventArgs e)
		{
			if (mnuToolbar.Checked == true)
			{
				mnuToolbar.Checked = false;
				tsMain.Visible = false;
			}
			else if (mnuToolbar.Checked == false)
			{
				mnuToolbar.Checked = true;
				tsMain.Visible = true;
			}

			// another way to code the if-else statement
			/*
			mnuToolbar.Checked = !mnuToolbar.Checked;
			tlbMain.Visible = !tlbMain.Visible;
			*/
		}

		private void mnuCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mnuTileVertical_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnuTileHorizontal_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void btnFutureValue_Click(object sender, EventArgs e)
		{
			mnuNewFutureValue.PerformClick();
		}

        private void btnDepreciation_Click(object sender, EventArgs e)
        {
            mnuNewDepreciation.PerformClick();
        }
	}
}