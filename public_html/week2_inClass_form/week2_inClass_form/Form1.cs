﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week2_inClass_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        string customerType = txtCustomerType.Text; 
        decimal subtotal = Convert.ToDecimal(txtSubtotal.Text); 
        decimal discountPercent = .0m; 

        if (customerType == "R") {
            if (subtotal < 100) discountPercent = .0m; 
            else if (subtotal >= 100 && subtotal < 250) discountPercent = .1m; 
            else if (subtotal >= 250) discountPercent =.25m; 
        } 
            else if (customerType == "C") { 
            if (subtotal < 250) discountPercent = .2m;
            } 
        else 
        discountPercent = .3m; 
        discountPercent = .4m; 
        } 
        decimal discountAmount = subtotal * discountPercent; 
        decimal invoiceTotal = subtotal - discountAmount; 
        txtDiscountPercent.Text = discountPercent.ToString("p1"); 
        txtDiscountAmount.Text = discountAmount.ToString("c"); 
        txtTotal.Text = invoiceTotal.ToString("c"); 
        txtCustomerType.Focus();
        }
    }
}
/*
private void btnCalculate Click(object sender, System.EventArgs e) 
{ 
string customerType = txtCustomerType.Text; decimal subtotal = Convert.ToDecimal(txtSubtotal.Text); decimal discountPercent = .Om; 
if (customerType == "R") { 
if (subtotal < 100) discountPercent = .Om; else if (subtotal >= 100 && subtotal < 250) discountPercent = .lm; else if (subtotal >= 250) discountPercent =.25m; 
} else if (customerType == "C") { if (subtotal < 250) discountPercent = .2m; 
else 
} 
else 
discountPercent = .3m; 
discountPercent = .4m; 
} 
decimal discountAmount = subtotal * discountPercent; decimal invoiceTotal = subtotal - discountAmount; 
txtDiscountPercent.Text = discountPercent.ToString("p1"); txtDiscountAmount.Text = discountAmount.ToString("c"); txtTotal.Text = invoiceTotal.ToString("c"); 
txtCustomerType.Focus(); 
}
*/