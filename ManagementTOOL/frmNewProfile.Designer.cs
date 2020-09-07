namespace ManagementTOOL
{
    partial class frmNewProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblswitch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxalias = new System.Windows.Forms.TextBox();
            this.tbxswitch = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // lblswitch
            // 
            this.lblswitch.AutoSize = true;
            this.lblswitch.Enabled = false;
            this.lblswitch.Location = new System.Drawing.Point(110, 170);
            this.lblswitch.Name = "lblswitch";
            this.lblswitch.Size = new System.Drawing.Size(44, 16);
            this.lblswitch.TabIndex = 2;
            this.lblswitch.Text = "switch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provider:";
            // 
            // tbxalias
            // 
            this.tbxalias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbxalias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxalias.Location = new System.Drawing.Point(239, 85);
            this.tbxalias.Name = "tbxalias";
            this.tbxalias.Size = new System.Drawing.Size(246, 22);
            this.tbxalias.TabIndex = 11;
            // 
            // tbxswitch
            // 
            this.tbxswitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbxswitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxswitch.Enabled = false;
            this.tbxswitch.Location = new System.Drawing.Point(239, 168);
            this.tbxswitch.Name = "tbxswitch";
            this.tbxswitch.Size = new System.Drawing.Size(246, 22);
            this.tbxswitch.TabIndex = 13;
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cbxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Credit Card",
            "Paypal"});
            this.cbxType.Location = new System.Drawing.Point(239, 125);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(246, 24);
            this.cbxType.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Credit Card",
            "Paypal"});
            this.comboBox1.Location = new System.Drawing.Point(239, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // frmNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.tbxswitch);
            this.Controls.Add(this.tbxalias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblswitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNewProfile";
            this.Text = "frmNewProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblswitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxalias;
        private System.Windows.Forms.TextBox tbxswitch;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}