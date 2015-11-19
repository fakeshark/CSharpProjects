namespace CommissionCalculator
{
    partial class frmCommissionCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionCalc));
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.lblBaseComission = new System.Windows.Forms.Label();
            this.lblLongevity = new System.Windows.Forms.Label();
            this.lblTitleIncentive = new System.Windows.Forms.Label();
            this.lblTotalCommission = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.txtBaseCommissionRate = new System.Windows.Forms.TextBox();
            this.txtLongevityRate = new System.Windows.Forms.TextBox();
            this.txtTitleIncentiveRate = new System.Windows.Forms.TextBox();
            this.txtTotalCommissionRate = new System.Windows.Forms.TextBox();
            this.txtTotalCommissionAmount = new System.Windows.Forms.TextBox();
            this.txtTitleIncentiveAmount = new System.Windows.Forms.TextBox();
            this.txtLongevityAmount = new System.Windows.Forms.TextBox();
            this.txtBaseCommissionAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblSalesPerson.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPerson.Location = new System.Drawing.Point(20, 17);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(86, 18);
            this.lblSalesPerson.TabIndex = 0;
            this.lblSalesPerson.Text = "Sales Person:";
            this.lblSalesPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblSalesAmount.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesAmount.Location = new System.Drawing.Point(20, 47);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(93, 18);
            this.lblSalesAmount.TabIndex = 1;
            this.lblSalesAmount.Text = "Sales Amount:";
            this.lblSalesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaseComission
            // 
            this.lblBaseComission.AutoSize = true;
            this.lblBaseComission.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblBaseComission.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseComission.Location = new System.Drawing.Point(20, 334);
            this.lblBaseComission.Name = "lblBaseComission";
            this.lblBaseComission.Size = new System.Drawing.Size(116, 18);
            this.lblBaseComission.TabIndex = 4;
            this.lblBaseComission.Text = "Base Commission:";
            this.lblBaseComission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaseComission.Click += new System.EventHandler(this.lblBaseComission_Click);
            // 
            // lblLongevity
            // 
            this.lblLongevity.AutoSize = true;
            this.lblLongevity.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblLongevity.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongevity.Location = new System.Drawing.Point(20, 364);
            this.lblLongevity.Name = "lblLongevity";
            this.lblLongevity.Size = new System.Drawing.Size(70, 18);
            this.lblLongevity.TabIndex = 5;
            this.lblLongevity.Text = "Longevity:";
            this.lblLongevity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLongevity.Click += new System.EventHandler(this.lblLongevity_Click);
            // 
            // lblTitleIncentive
            // 
            this.lblTitleIncentive.AutoSize = true;
            this.lblTitleIncentive.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitleIncentive.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIncentive.Location = new System.Drawing.Point(20, 394);
            this.lblTitleIncentive.Name = "lblTitleIncentive";
            this.lblTitleIncentive.Size = new System.Drawing.Size(94, 18);
            this.lblTitleIncentive.TabIndex = 6;
            this.lblTitleIncentive.Text = "Title Incentive:";
            this.lblTitleIncentive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleIncentive.Click += new System.EventHandler(this.lblTitleIncentive_Click);
            // 
            // lblTotalCommission
            // 
            this.lblTotalCommission.AutoSize = true;
            this.lblTotalCommission.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblTotalCommission.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCommission.Location = new System.Drawing.Point(20, 424);
            this.lblTotalCommission.Name = "lblTotalCommission";
            this.lblTotalCommission.Size = new System.Drawing.Size(118, 18);
            this.lblTotalCommission.TabIndex = 7;
            this.lblTotalCommission.Text = "Total Commission:";
            this.lblTotalCommission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalCommission.Click += new System.EventHandler(this.lblTotalCommission_Click);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblRate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(157, 307);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(35, 18);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Rate";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblAmount.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(239, 307);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 18);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Gold;
            this.btnCalculate.Location = new System.Drawing.Point(331, 16);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 60);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(331, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 60);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Open Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(331, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.BackColor = System.Drawing.Color.Lavender;
            this.txtSalesPerson.Location = new System.Drawing.Point(144, 17);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(170, 20);
            this.txtSalesPerson.TabIndex = 0;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.BackColor = System.Drawing.Color.Lavender;
            this.txtSalesAmount.Location = new System.Drawing.Point(144, 47);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(170, 20);
            this.txtSalesAmount.TabIndex = 1;
            // 
            // txtBaseCommissionRate
            // 
            this.txtBaseCommissionRate.BackColor = System.Drawing.Color.OldLace;
            this.txtBaseCommissionRate.Location = new System.Drawing.Point(144, 334);
            this.txtBaseCommissionRate.Name = "txtBaseCommissionRate";
            this.txtBaseCommissionRate.ReadOnly = true;
            this.txtBaseCommissionRate.Size = new System.Drawing.Size(61, 20);
            this.txtBaseCommissionRate.TabIndex = 16;
            this.txtBaseCommissionRate.TabStop = false;
            this.txtBaseCommissionRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaseCommissionRate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLongevityRate
            // 
            this.txtLongevityRate.BackColor = System.Drawing.Color.OldLace;
            this.txtLongevityRate.Location = new System.Drawing.Point(144, 364);
            this.txtLongevityRate.Name = "txtLongevityRate";
            this.txtLongevityRate.ReadOnly = true;
            this.txtLongevityRate.Size = new System.Drawing.Size(61, 20);
            this.txtLongevityRate.TabIndex = 17;
            this.txtLongevityRate.TabStop = false;
            this.txtLongevityRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLongevityRate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTitleIncentiveRate
            // 
            this.txtTitleIncentiveRate.BackColor = System.Drawing.Color.OldLace;
            this.txtTitleIncentiveRate.Location = new System.Drawing.Point(144, 394);
            this.txtTitleIncentiveRate.Name = "txtTitleIncentiveRate";
            this.txtTitleIncentiveRate.ReadOnly = true;
            this.txtTitleIncentiveRate.Size = new System.Drawing.Size(61, 20);
            this.txtTitleIncentiveRate.TabIndex = 18;
            this.txtTitleIncentiveRate.TabStop = false;
            this.txtTitleIncentiveRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTitleIncentiveRate.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtTotalCommissionRate
            // 
            this.txtTotalCommissionRate.BackColor = System.Drawing.Color.OldLace;
            this.txtTotalCommissionRate.Location = new System.Drawing.Point(144, 424);
            this.txtTotalCommissionRate.Name = "txtTotalCommissionRate";
            this.txtTotalCommissionRate.ReadOnly = true;
            this.txtTotalCommissionRate.Size = new System.Drawing.Size(61, 20);
            this.txtTotalCommissionRate.TabIndex = 19;
            this.txtTotalCommissionRate.TabStop = false;
            this.txtTotalCommissionRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCommissionRate.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTotalCommissionAmount
            // 
            this.txtTotalCommissionAmount.BackColor = System.Drawing.Color.OldLace;
            this.txtTotalCommissionAmount.Location = new System.Drawing.Point(222, 424);
            this.txtTotalCommissionAmount.Name = "txtTotalCommissionAmount";
            this.txtTotalCommissionAmount.ReadOnly = true;
            this.txtTotalCommissionAmount.Size = new System.Drawing.Size(92, 20);
            this.txtTotalCommissionAmount.TabIndex = 23;
            this.txtTotalCommissionAmount.TabStop = false;
            this.txtTotalCommissionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalCommissionAmount.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtTitleIncentiveAmount
            // 
            this.txtTitleIncentiveAmount.BackColor = System.Drawing.Color.OldLace;
            this.txtTitleIncentiveAmount.Location = new System.Drawing.Point(222, 394);
            this.txtTitleIncentiveAmount.Name = "txtTitleIncentiveAmount";
            this.txtTitleIncentiveAmount.ReadOnly = true;
            this.txtTitleIncentiveAmount.Size = new System.Drawing.Size(92, 20);
            this.txtTitleIncentiveAmount.TabIndex = 22;
            this.txtTitleIncentiveAmount.TabStop = false;
            this.txtTitleIncentiveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTitleIncentiveAmount.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtLongevityAmount
            // 
            this.txtLongevityAmount.BackColor = System.Drawing.Color.OldLace;
            this.txtLongevityAmount.Location = new System.Drawing.Point(222, 364);
            this.txtLongevityAmount.Name = "txtLongevityAmount";
            this.txtLongevityAmount.ReadOnly = true;
            this.txtLongevityAmount.Size = new System.Drawing.Size(92, 20);
            this.txtLongevityAmount.TabIndex = 21;
            this.txtLongevityAmount.TabStop = false;
            this.txtLongevityAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLongevityAmount.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtBaseCommissionAmount
            // 
            this.txtBaseCommissionAmount.BackColor = System.Drawing.Color.OldLace;
            this.txtBaseCommissionAmount.Location = new System.Drawing.Point(222, 334);
            this.txtBaseCommissionAmount.Name = "txtBaseCommissionAmount";
            this.txtBaseCommissionAmount.ReadOnly = true;
            this.txtBaseCommissionAmount.Size = new System.Drawing.Size(92, 20);
            this.txtBaseCommissionAmount.TabIndex = 20;
            this.txtBaseCommissionAmount.TabStop = false;
            this.txtBaseCommissionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaseCommissionAmount.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(23, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 95);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Years of Service:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(76, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "10 or More";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Between 5 -9";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Less than 5";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(23, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 95);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Title:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 68);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 17);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "Senior";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 44);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "Associate";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(76, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Apprentice";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // frmCommissionCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(424, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotalCommissionAmount);
            this.Controls.Add(this.txtTitleIncentiveAmount);
            this.Controls.Add(this.txtLongevityAmount);
            this.Controls.Add(this.txtBaseCommissionAmount);
            this.Controls.Add(this.txtTotalCommissionRate);
            this.Controls.Add(this.txtTitleIncentiveRate);
            this.Controls.Add(this.txtLongevityRate);
            this.Controls.Add(this.txtBaseCommissionRate);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblTotalCommission);
            this.Controls.Add(this.lblTitleIncentive);
            this.Controls.Add(this.lblLongevity);
            this.Controls.Add(this.lblBaseComission);
            this.Controls.Add(this.lblSalesAmount);
            this.Controls.Add(this.lblSalesPerson);
            this.Name = "frmCommissionCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commission Calculator";
            this.Load += new System.EventHandler(this.frmCommissionCalc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.Label lblBaseComission;
        private System.Windows.Forms.Label lblLongevity;
        private System.Windows.Forms.Label lblTitleIncentive;
        private System.Windows.Forms.Label lblTotalCommission;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.TextBox txtBaseCommissionRate;
        private System.Windows.Forms.TextBox txtLongevityRate;
        private System.Windows.Forms.TextBox txtTitleIncentiveRate;
        private System.Windows.Forms.TextBox txtTotalCommissionRate;
        private System.Windows.Forms.TextBox txtTotalCommissionAmount;
        private System.Windows.Forms.TextBox txtTitleIncentiveAmount;
        private System.Windows.Forms.TextBox txtLongevityAmount;
        private System.Windows.Forms.TextBox txtBaseCommissionAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

