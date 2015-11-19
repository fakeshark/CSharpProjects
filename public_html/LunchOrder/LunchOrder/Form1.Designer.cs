namespace LunchOrder
{
    partial class frmLunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunchOrder));
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.gbxAddOnItems = new System.Windows.Forms.GroupBox();
            this.chkCheckBox3 = new System.Windows.Forms.CheckBox();
            this.chkCheckBox2 = new System.Windows.Forms.CheckBox();
            this.chkCheckBox1 = new System.Windows.Forms.CheckBox();
            this.gbxOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOnItems.SuspendLayout();
            this.gbxOrderTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoSalad);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Controls.Add(this.rdoHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(20, 17);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(200, 140);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course:";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(20, 105);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(20, 67);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Checked = true;
            this.rdoHamburger.Location = new System.Drawing.Point(20, 30);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // gbxAddOnItems
            // 
            this.gbxAddOnItems.Controls.Add(this.chkCheckBox3);
            this.gbxAddOnItems.Controls.Add(this.chkCheckBox2);
            this.gbxAddOnItems.Controls.Add(this.chkCheckBox1);
            this.gbxAddOnItems.Location = new System.Drawing.Point(239, 17);
            this.gbxAddOnItems.Name = "gbxAddOnItems";
            this.gbxAddOnItems.Size = new System.Drawing.Size(200, 140);
            this.gbxAddOnItems.TabIndex = 1;
            this.gbxAddOnItems.TabStop = false;
            this.gbxAddOnItems.Text = "Add-on Items:  ( 75¢ ea. )";
            // 
            // chkCheckBox3
            // 
            this.chkCheckBox3.AutoSize = true;
            this.chkCheckBox3.Location = new System.Drawing.Point(22, 105);
            this.chkCheckBox3.Name = "chkCheckBox3";
            this.chkCheckBox3.Size = new System.Drawing.Size(84, 17);
            this.chkCheckBox3.TabIndex = 5;
            this.chkCheckBox3.Text = "French Fries";
            this.chkCheckBox3.UseVisualStyleBackColor = true;
            // 
            // chkCheckBox2
            // 
            this.chkCheckBox2.AutoSize = true;
            this.chkCheckBox2.Location = new System.Drawing.Point(22, 67);
            this.chkCheckBox2.Name = "chkCheckBox2";
            this.chkCheckBox2.Size = new System.Drawing.Size(142, 17);
            this.chkCheckBox2.TabIndex = 4;
            this.chkCheckBox2.Text = "Ketchup, Mustard, Mayo";
            this.chkCheckBox2.UseVisualStyleBackColor = true;
            // 
            // chkCheckBox1
            // 
            this.chkCheckBox1.AutoSize = true;
            this.chkCheckBox1.Location = new System.Drawing.Point(22, 30);
            this.chkCheckBox1.Name = "chkCheckBox1";
            this.chkCheckBox1.Size = new System.Drawing.Size(138, 17);
            this.chkCheckBox1.TabIndex = 3;
            this.chkCheckBox1.Text = "Lettuce, Tomato, Onion";
            this.chkCheckBox1.UseVisualStyleBackColor = true;
            // 
            // gbxOrderTotal
            // 
            this.gbxOrderTotal.Controls.Add(this.txtOrderTotal);
            this.gbxOrderTotal.Controls.Add(this.txtSalesTax);
            this.gbxOrderTotal.Controls.Add(this.txtSubtotal);
            this.gbxOrderTotal.Controls.Add(this.lblTotal);
            this.gbxOrderTotal.Controls.Add(this.lblSalesTax);
            this.gbxOrderTotal.Controls.Add(this.lblSubtotal);
            this.gbxOrderTotal.Location = new System.Drawing.Point(20, 170);
            this.gbxOrderTotal.Name = "gbxOrderTotal";
            this.gbxOrderTotal.Size = new System.Drawing.Size(300, 153);
            this.gbxOrderTotal.TabIndex = 2;
            this.gbxOrderTotal.TabStop = false;
            this.gbxOrderTotal.Text = "Order Total:";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(137, 111);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(132, 20);
            this.txtOrderTotal.TabIndex = 6;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(137, 71);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(132, 20);
            this.txtSalesTax.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(137, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(132, 20);
            this.txtSubtotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 114);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Order Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(17, 74);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(95, 13);
            this.lblSalesTax.TabIndex = 1;
            this.lblSalesTax.Text = "Sales Tax: (7.75%)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(17, 31);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(338, 175);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(101, 65);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(338, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 65);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 300);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(658, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.gbxOrderTotal);
            this.Controls.Add(this.gbxAddOnItems);
            this.Controls.Add(this.gbxMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOnItems.ResumeLayout(false);
            this.gbxAddOnItems.PerformLayout();
            this.gbxOrderTotal.ResumeLayout(false);
            this.gbxOrderTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox gbxAddOnItems;
        private System.Windows.Forms.CheckBox chkCheckBox3;
        private System.Windows.Forms.CheckBox chkCheckBox2;
        private System.Windows.Forms.CheckBox chkCheckBox1;
        private System.Windows.Forms.GroupBox gbxOrderTotal;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

