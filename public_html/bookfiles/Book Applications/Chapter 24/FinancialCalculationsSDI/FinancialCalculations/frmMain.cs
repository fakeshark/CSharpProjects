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
    // This application is described in chapter 24 of
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnFutureValue_Click(object sender, System.EventArgs e)
		{
			Form newForm = new frmFutureValue();
			newForm.Show();
		}

		private void btnCalculateDepreciation_Click(object sender, System.EventArgs e)
		{
			Form newForm = new frmDepreciation();
			newForm.Show();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

	}
}