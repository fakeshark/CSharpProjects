namespace Multiform1
{
    partial class frmPayment
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
            this.gbxBilling = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.lbxCardType = new System.Windows.Forms.ListBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cbxExpDateMonth = new System.Windows.Forms.ComboBox();
            this.chkSetAsDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxExpDateYear = new System.Windows.Forms.ComboBox();
            this.gbxBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBilling
            // 
            this.gbxBilling.Controls.Add(this.rdoBillCustomer);
            this.gbxBilling.Controls.Add(this.rdoCreditCard);
            this.gbxBilling.Location = new System.Drawing.Point(34, 33);
            this.gbxBilling.Name = "gbxBilling";
            this.gbxBilling.Size = new System.Drawing.Size(350, 70);
            this.gbxBilling.TabIndex = 0;
            this.gbxBilling.TabStop = false;
            this.gbxBilling.Text = "Billing:";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(217, 31);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(85, 17);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill Customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(41, 31);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.AutoSize = true;
            this.lblCreditCardType.Location = new System.Drawing.Point(31, 124);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Size = new System.Drawing.Size(89, 13);
            this.lblCreditCardType.TabIndex = 1;
            this.lblCreditCardType.Text = "Credit Card Type:";
            // 
            // lbxCardType
            // 
            this.lbxCardType.FormattingEnabled = true;
            this.lbxCardType.Location = new System.Drawing.Point(145, 126);
            this.lbxCardType.Name = "lbxCardType";
            this.lbxCardType.Size = new System.Drawing.Size(239, 69);
            this.lbxCardType.TabIndex = 2;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(31, 214);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(72, 13);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(145, 214);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(239, 20);
            this.txtCardNumber.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(31, 263);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // cbxExpDateMonth
            // 
            this.cbxExpDateMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpDateMonth.FormattingEnabled = true;
            this.cbxExpDateMonth.Location = new System.Drawing.Point(145, 252);
            this.cbxExpDateMonth.Name = "cbxExpDateMonth";
            this.cbxExpDateMonth.Size = new System.Drawing.Size(110, 21);
            this.cbxExpDateMonth.TabIndex = 6;
            // 
            // chkSetAsDefault
            // 
            this.chkSetAsDefault.AutoSize = true;
            this.chkSetAsDefault.Checked = true;
            this.chkSetAsDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSetAsDefault.Location = new System.Drawing.Point(34, 298);
            this.chkSetAsDefault.Name = "chkSetAsDefault";
            this.chkSetAsDefault.Size = new System.Drawing.Size(158, 17);
            this.chkSetAsDefault.TabIndex = 8;
            this.chkSetAsDefault.Text = "Set as default billing method";
            this.chkSetAsDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(176, 333);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(289, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // cbxExpDateYear
            // 
            this.cbxExpDateYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExpDateYear.FormattingEnabled = true;
            this.cbxExpDateYear.Location = new System.Drawing.Point(274, 252);
            this.cbxExpDateYear.Name = "cbxExpDateYear";
            this.cbxExpDateYear.Size = new System.Drawing.Size(110, 21);
            this.cbxExpDateYear.TabIndex = 11;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(416, 386);
            this.ControlBox = false;
            this.Controls.Add(this.cbxExpDateYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkSetAsDefault);
            this.Controls.Add(this.cbxExpDateMonth);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lbxCardType);
            this.Controls.Add(this.lblCreditCardType);
            this.Controls.Add(this.gbxBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.Text = " Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbxBilling.ResumeLayout(false);
            this.gbxBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBilling;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label lblCreditCardType;
        private System.Windows.Forms.ListBox lbxCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cbxExpDateMonth;
        private System.Windows.Forms.CheckBox chkSetAsDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxExpDateYear;
    }
}