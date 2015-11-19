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
    // This application is described in chapter 1 of
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnInvestment_Click(object sender, EventArgs e)
		{
			frmInvestment form = new frmInvestment();
			form.Show();
		}

		private void btnDepreciation_Click(object sender, EventArgs e)
		{
			frmDepreciation form = new frmDepreciation();
			form.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}