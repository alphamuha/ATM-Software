
namespace ATM_Software
{
    partial class Form2
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
            this.lblCashAvailability = new System.Windows.Forms.Label();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnPinClearLast = new System.Windows.Forms.Button();
            this.btnPin0 = new System.Windows.Forms.Button();
            this.btnPinClearAll = new System.Windows.Forms.Button();
            this.btnPin9 = new System.Windows.Forms.Button();
            this.btnPin8 = new System.Windows.Forms.Button();
            this.btnPin7 = new System.Windows.Forms.Button();
            this.btnPin6 = new System.Windows.Forms.Button();
            this.btnPin5 = new System.Windows.Forms.Button();
            this.btnPin4 = new System.Windows.Forms.Button();
            this.btnPin3 = new System.Windows.Forms.Button();
            this.btnPin2 = new System.Windows.Forms.Button();
            this.btnPin1 = new System.Windows.Forms.Button();
            this.txtBoxPin = new System.Windows.Forms.TextBox();
            this.lblPogresanPin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCashAvailability
            // 
            this.lblCashAvailability.AutoSize = true;
            this.lblCashAvailability.BackColor = System.Drawing.Color.White;
            this.lblCashAvailability.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCashAvailability.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblCashAvailability.Location = new System.Drawing.Point(12, 9);
            this.lblCashAvailability.Name = "lblCashAvailability";
            this.lblCashAvailability.Size = new System.Drawing.Size(46, 45);
            this.lblCashAvailability.TabIndex = 0;
            this.lblCashAvailability.Text = "--";
            this.lblCashAvailability.Click += new System.EventHandler(this.lblCashAvailability_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdrawal.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWithdrawal.ForeColor = System.Drawing.Color.Black;
            this.btnWithdrawal.Location = new System.Drawing.Point(550, 389);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(238, 49);
            this.btnWithdrawal.TabIndex = 1;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnPinClearLast
            // 
            this.btnPinClearLast.BackColor = System.Drawing.Color.Transparent;
            this.btnPinClearLast.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPinClearLast.ForeColor = System.Drawing.Color.Black;
            this.btnPinClearLast.Location = new System.Drawing.Point(247, 376);
            this.btnPinClearLast.Name = "btnPinClearLast";
            this.btnPinClearLast.Size = new System.Drawing.Size(112, 64);
            this.btnPinClearLast.TabIndex = 27;
            this.btnPinClearLast.Text = "<";
            this.btnPinClearLast.UseVisualStyleBackColor = false;
            this.btnPinClearLast.Click += new System.EventHandler(this.btnPinClearLast_Click);
            // 
            // btnPin0
            // 
            this.btnPin0.BackColor = System.Drawing.Color.Transparent;
            this.btnPin0.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin0.ForeColor = System.Drawing.Color.Black;
            this.btnPin0.Location = new System.Drawing.Point(129, 376);
            this.btnPin0.Name = "btnPin0";
            this.btnPin0.Size = new System.Drawing.Size(112, 64);
            this.btnPin0.TabIndex = 26;
            this.btnPin0.Text = "0";
            this.btnPin0.UseVisualStyleBackColor = false;
            this.btnPin0.Click += new System.EventHandler(this.btnPin0_Click);
            // 
            // btnPinClearAll
            // 
            this.btnPinClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnPinClearAll.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPinClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnPinClearAll.Location = new System.Drawing.Point(11, 376);
            this.btnPinClearAll.Name = "btnPinClearAll";
            this.btnPinClearAll.Size = new System.Drawing.Size(112, 64);
            this.btnPinClearAll.TabIndex = 25;
            this.btnPinClearAll.Text = "Clear All";
            this.btnPinClearAll.UseVisualStyleBackColor = false;
            this.btnPinClearAll.Click += new System.EventHandler(this.btnPinClearAll_Click);
            // 
            // btnPin9
            // 
            this.btnPin9.BackColor = System.Drawing.Color.Transparent;
            this.btnPin9.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin9.ForeColor = System.Drawing.Color.Black;
            this.btnPin9.Location = new System.Drawing.Point(247, 306);
            this.btnPin9.Name = "btnPin9";
            this.btnPin9.Size = new System.Drawing.Size(112, 64);
            this.btnPin9.TabIndex = 24;
            this.btnPin9.Text = "9";
            this.btnPin9.UseVisualStyleBackColor = false;
            this.btnPin9.Click += new System.EventHandler(this.btnPin9_Click);
            // 
            // btnPin8
            // 
            this.btnPin8.BackColor = System.Drawing.Color.Transparent;
            this.btnPin8.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin8.ForeColor = System.Drawing.Color.Black;
            this.btnPin8.Location = new System.Drawing.Point(129, 306);
            this.btnPin8.Name = "btnPin8";
            this.btnPin8.Size = new System.Drawing.Size(112, 64);
            this.btnPin8.TabIndex = 23;
            this.btnPin8.Text = "8";
            this.btnPin8.UseVisualStyleBackColor = false;
            this.btnPin8.Click += new System.EventHandler(this.btnPin8_Click);
            // 
            // btnPin7
            // 
            this.btnPin7.BackColor = System.Drawing.Color.Transparent;
            this.btnPin7.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin7.ForeColor = System.Drawing.Color.Black;
            this.btnPin7.Location = new System.Drawing.Point(11, 306);
            this.btnPin7.Name = "btnPin7";
            this.btnPin7.Size = new System.Drawing.Size(112, 64);
            this.btnPin7.TabIndex = 22;
            this.btnPin7.Text = "7";
            this.btnPin7.UseVisualStyleBackColor = false;
            this.btnPin7.Click += new System.EventHandler(this.btnPin7_Click);
            // 
            // btnPin6
            // 
            this.btnPin6.BackColor = System.Drawing.Color.Transparent;
            this.btnPin6.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin6.ForeColor = System.Drawing.Color.Black;
            this.btnPin6.Location = new System.Drawing.Point(247, 236);
            this.btnPin6.Name = "btnPin6";
            this.btnPin6.Size = new System.Drawing.Size(112, 64);
            this.btnPin6.TabIndex = 21;
            this.btnPin6.Text = "6";
            this.btnPin6.UseVisualStyleBackColor = false;
            this.btnPin6.Click += new System.EventHandler(this.btnPin6_Click);
            // 
            // btnPin5
            // 
            this.btnPin5.BackColor = System.Drawing.Color.Transparent;
            this.btnPin5.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin5.ForeColor = System.Drawing.Color.Black;
            this.btnPin5.Location = new System.Drawing.Point(129, 236);
            this.btnPin5.Name = "btnPin5";
            this.btnPin5.Size = new System.Drawing.Size(112, 64);
            this.btnPin5.TabIndex = 20;
            this.btnPin5.Text = "5";
            this.btnPin5.UseVisualStyleBackColor = false;
            this.btnPin5.Click += new System.EventHandler(this.btnPin5_Click);
            // 
            // btnPin4
            // 
            this.btnPin4.BackColor = System.Drawing.Color.Transparent;
            this.btnPin4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin4.ForeColor = System.Drawing.Color.Black;
            this.btnPin4.Location = new System.Drawing.Point(11, 236);
            this.btnPin4.Name = "btnPin4";
            this.btnPin4.Size = new System.Drawing.Size(112, 64);
            this.btnPin4.TabIndex = 19;
            this.btnPin4.Text = "4";
            this.btnPin4.UseVisualStyleBackColor = false;
            this.btnPin4.Click += new System.EventHandler(this.btnPin4_Click);
            // 
            // btnPin3
            // 
            this.btnPin3.BackColor = System.Drawing.Color.Transparent;
            this.btnPin3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin3.ForeColor = System.Drawing.Color.Black;
            this.btnPin3.Location = new System.Drawing.Point(247, 166);
            this.btnPin3.Name = "btnPin3";
            this.btnPin3.Size = new System.Drawing.Size(112, 64);
            this.btnPin3.TabIndex = 18;
            this.btnPin3.Text = "3";
            this.btnPin3.UseVisualStyleBackColor = false;
            this.btnPin3.Click += new System.EventHandler(this.btnPin3_Click);
            // 
            // btnPin2
            // 
            this.btnPin2.BackColor = System.Drawing.Color.Transparent;
            this.btnPin2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin2.ForeColor = System.Drawing.Color.Black;
            this.btnPin2.Location = new System.Drawing.Point(129, 166);
            this.btnPin2.Name = "btnPin2";
            this.btnPin2.Size = new System.Drawing.Size(112, 64);
            this.btnPin2.TabIndex = 17;
            this.btnPin2.Text = "2";
            this.btnPin2.UseVisualStyleBackColor = false;
            this.btnPin2.Click += new System.EventHandler(this.btnPin2_Click);
            // 
            // btnPin1
            // 
            this.btnPin1.BackColor = System.Drawing.Color.Transparent;
            this.btnPin1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPin1.ForeColor = System.Drawing.Color.Black;
            this.btnPin1.Location = new System.Drawing.Point(11, 166);
            this.btnPin1.Name = "btnPin1";
            this.btnPin1.Size = new System.Drawing.Size(112, 64);
            this.btnPin1.TabIndex = 16;
            this.btnPin1.Text = "1";
            this.btnPin1.UseVisualStyleBackColor = false;
            this.btnPin1.Click += new System.EventHandler(this.btnPin1_Click);
            // 
            // txtBoxPin
            // 
            this.txtBoxPin.BackColor = System.Drawing.Color.White;
            this.txtBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPin.ForeColor = System.Drawing.Color.Black;
            this.txtBoxPin.Location = new System.Drawing.Point(11, 72);
            this.txtBoxPin.Multiline = true;
            this.txtBoxPin.Name = "txtBoxPin";
            this.txtBoxPin.Size = new System.Drawing.Size(348, 40);
            this.txtBoxPin.TabIndex = 28;
            // 
            // lblPogresanPin
            // 
            this.lblPogresanPin.AutoSize = true;
            this.lblPogresanPin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPogresanPin.ForeColor = System.Drawing.Color.Red;
            this.lblPogresanPin.Location = new System.Drawing.Point(14, 115);
            this.lblPogresanPin.Name = "lblPogresanPin";
            this.lblPogresanPin.Size = new System.Drawing.Size(0, 32);
            this.lblPogresanPin.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPogresanPin);
            this.Controls.Add(this.txtBoxPin);
            this.Controls.Add(this.btnPinClearLast);
            this.Controls.Add(this.btnPin0);
            this.Controls.Add(this.btnPinClearAll);
            this.Controls.Add(this.btnPin9);
            this.Controls.Add(this.btnPin8);
            this.Controls.Add(this.btnPin7);
            this.Controls.Add(this.btnPin6);
            this.Controls.Add(this.btnPin5);
            this.Controls.Add(this.btnPin4);
            this.Controls.Add(this.btnPin3);
            this.Controls.Add(this.btnPin2);
            this.Controls.Add(this.btnPin1);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.lblCashAvailability);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCashAvailability;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnPinClearLast;
        private System.Windows.Forms.Button btnPin0;
        private System.Windows.Forms.Button btnPinClearAll;
        private System.Windows.Forms.Button btnPin9;
        private System.Windows.Forms.Button btnPin8;
        private System.Windows.Forms.Button btnPin7;
        private System.Windows.Forms.Button btnPin6;
        private System.Windows.Forms.Button btnPin5;
        private System.Windows.Forms.Button btnPin4;
        private System.Windows.Forms.Button btnPin3;
        private System.Windows.Forms.Button btnPin2;
        private System.Windows.Forms.Button btnPin1;
        private System.Windows.Forms.TextBox txtBoxPin;
        private System.Windows.Forms.Label lblPogresanPin;
    }
}