namespace AgeCalculation
{
    partial class frmDateHandling
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
            this.txtEnterFutureDate = new System.Windows.Forms.TextBox();
            this.txtEnterBirthDate = new System.Windows.Forms.TextBox();
            this.lblEnterFutureDate = new System.Windows.Forms.Label();
            this.lblEnterBirthDate = new System.Windows.Forms.Label();
            this.btnCalculateDueDate = new System.Windows.Forms.Button();
            this.btnCalculateAge = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnterFutureDate
            // 
            this.txtEnterFutureDate.Location = new System.Drawing.Point(119, 27);
            this.txtEnterFutureDate.Name = "txtEnterFutureDate";
            this.txtEnterFutureDate.Size = new System.Drawing.Size(100, 20);
            this.txtEnterFutureDate.TabIndex = 0;
            this.txtEnterFutureDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEnterBirthDate
            // 
            this.txtEnterBirthDate.Location = new System.Drawing.Point(119, 57);
            this.txtEnterBirthDate.Name = "txtEnterBirthDate";
            this.txtEnterBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtEnterBirthDate.TabIndex = 1;
            // 
            // lblEnterFutureDate
            // 
            this.lblEnterFutureDate.AutoSize = true;
            this.lblEnterFutureDate.Location = new System.Drawing.Point(19, 30);
            this.lblEnterFutureDate.Name = "lblEnterFutureDate";
            this.lblEnterFutureDate.Size = new System.Drawing.Size(94, 13);
            this.lblEnterFutureDate.TabIndex = 2;
            this.lblEnterFutureDate.Text = "Enter Future Date:";
            this.lblEnterFutureDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnterBirthDate
            // 
            this.lblEnterBirthDate.AutoSize = true;
            this.lblEnterBirthDate.Location = new System.Drawing.Point(19, 60);
            this.lblEnterBirthDate.Name = "lblEnterBirthDate";
            this.lblEnterBirthDate.Size = new System.Drawing.Size(85, 13);
            this.lblEnterBirthDate.TabIndex = 3;
            this.lblEnterBirthDate.Text = "Enter Birth Date:";
            this.lblEnterBirthDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalculateDueDate
            // 
            this.btnCalculateDueDate.Location = new System.Drawing.Point(241, 25);
            this.btnCalculateDueDate.Name = "btnCalculateDueDate";
            this.btnCalculateDueDate.Size = new System.Drawing.Size(140, 23);
            this.btnCalculateDueDate.TabIndex = 4;
            this.btnCalculateDueDate.Text = "Calculate Due Date";
            this.btnCalculateDueDate.UseVisualStyleBackColor = true;
            this.btnCalculateDueDate.Click += new System.EventHandler(this.btnCalculateDueDate_Click);
            // 
            // btnCalculateAge
            // 
            this.btnCalculateAge.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculateAge.Location = new System.Drawing.Point(241, 55);
            this.btnCalculateAge.Name = "btnCalculateAge";
            this.btnCalculateAge.Size = new System.Drawing.Size(139, 23);
            this.btnCalculateAge.TabIndex = 5;
            this.btnCalculateAge.Text = "Calculate Age";
            this.btnCalculateAge.UseVisualStyleBackColor = true;
            this.btnCalculateAge.Click += new System.EventHandler(this.btnCalculateAge_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(241, 85);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmDateHandling
            // 
            this.AcceptButton = this.btnCalculateDueDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(403, 132);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateAge);
            this.Controls.Add(this.btnCalculateDueDate);
            this.Controls.Add(this.lblEnterBirthDate);
            this.Controls.Add(this.lblEnterFutureDate);
            this.Controls.Add(this.txtEnterBirthDate);
            this.Controls.Add(this.txtEnterFutureDate);
            this.Name = "frmDateHandling";
            this.Text = "Date Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterFutureDate;
        private System.Windows.Forms.TextBox txtEnterBirthDate;
        private System.Windows.Forms.Label lblEnterFutureDate;
        private System.Windows.Forms.Label lblEnterBirthDate;
        private System.Windows.Forms.Button btnCalculateDueDate;
        private System.Windows.Forms.Button btnCalculateAge;
        private System.Windows.Forms.Button btnExit;
    }
}

