namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.maskTC = new System.Windows.Forms.Label();
            this.maskTelefon = new System.Windows.Forms.Label();
            this.maskDTarih = new System.Windows.Forms.Label();
            this.maskKart = new System.Windows.Forms.Label();
            this.maskIp = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskTC
            // 
            this.maskTC.AutoSize = true;
            this.maskTC.Location = new System.Drawing.Point(117, 48);
            this.maskTC.Name = "maskTC";
            this.maskTC.Size = new System.Drawing.Size(31, 13);
            this.maskTC.TabIndex = 0;
            this.maskTC.Text = "tc.no";
            // 
            // maskTelefon
            // 
            this.maskTelefon.AutoSize = true;
            this.maskTelefon.Location = new System.Drawing.Point(117, 71);
            this.maskTelefon.Name = "maskTelefon";
            this.maskTelefon.Size = new System.Drawing.Size(39, 13);
            this.maskTelefon.TabIndex = 1;
            this.maskTelefon.Text = "telefon";
            // 
            // maskDTarih
            // 
            this.maskDTarih.AutoSize = true;
            this.maskDTarih.Location = new System.Drawing.Point(104, 97);
            this.maskDTarih.Name = "maskDTarih";
            this.maskDTarih.Size = new System.Drawing.Size(64, 13);
            this.maskDTarih.TabIndex = 2;
            this.maskDTarih.Text = "doğum tarihi";
            // 
            // maskKart
            // 
            this.maskKart.AutoSize = true;
            this.maskKart.Location = new System.Drawing.Point(117, 123);
            this.maskKart.Name = "maskKart";
            this.maskKart.Size = new System.Drawing.Size(40, 13);
            this.maskKart.TabIndex = 3;
            this.maskKart.Text = "kart no";
            // 
            // maskIp
            // 
            this.maskIp.AutoSize = true;
            this.maskIp.Location = new System.Drawing.Point(117, 147);
            this.maskIp.Name = "maskIp";
            this.maskIp.Size = new System.Drawing.Size(44, 13);
            this.maskIp.TabIndex = 4;
            this.maskIp.Text = "ıp adres";
            this.maskIp.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(184, 45);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(184, 71);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(184, 97);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(184, 123);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox4.TabIndex = 13;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(167, 149);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 261);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.maskIp);
            this.Controls.Add(this.maskKart);
            this.Controls.Add(this.maskDTarih);
            this.Controls.Add(this.maskTelefon);
            this.Controls.Add(this.maskTC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maskTC;
        private System.Windows.Forms.Label maskTelefon;
        private System.Windows.Forms.Label maskDTarih;
        private System.Windows.Forms.Label maskKart;
        private System.Windows.Forms.Label maskIp;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
    }
}

