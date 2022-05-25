
namespace instagram_takipci_uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.lbxTakipciler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lbxTakipEdilen = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxTakiplestiklerin = new System.Windows.Forms.ListBox();
            this.lbxTakipEtmeyenler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(254, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "İnstagram Takipçi Sorgulama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(281, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(336, 113);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(140, 23);
            this.txtKadi.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(336, 152);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(140, 23);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSorgula.Location = new System.Drawing.Point(501, 120);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(98, 47);
            this.btnSorgula.TabIndex = 5;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // lbxTakipciler
            // 
            this.lbxTakipciler.FormattingEnabled = true;
            this.lbxTakipciler.ItemHeight = 15;
            this.lbxTakipciler.Location = new System.Drawing.Point(24, 268);
            this.lbxTakipciler.Name = "lbxTakipciler";
            this.lbxTakipciler.Size = new System.Drawing.Size(164, 394);
            this.lbxTakipciler.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Takipçiler";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBilgi.ForeColor = System.Drawing.Color.Lime;
            this.lblBilgi.Location = new System.Drawing.Point(646, 129);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(0, 28);
            this.lblBilgi.TabIndex = 8;
            // 
            // lbxTakipEdilen
            // 
            this.lbxTakipEdilen.FormattingEnabled = true;
            this.lbxTakipEdilen.ItemHeight = 15;
            this.lbxTakipEdilen.Location = new System.Drawing.Point(214, 268);
            this.lbxTakipEdilen.Name = "lbxTakipEdilen";
            this.lbxTakipEdilen.Size = new System.Drawing.Size(164, 394);
            this.lbxTakipEdilen.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(238, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Takip Ettiklerin";
            // 
            // lbxTakiplestiklerin
            // 
            this.lbxTakiplestiklerin.FormattingEnabled = true;
            this.lbxTakiplestiklerin.ItemHeight = 15;
            this.lbxTakiplestiklerin.Location = new System.Drawing.Point(407, 268);
            this.lbxTakiplestiklerin.Name = "lbxTakiplestiklerin";
            this.lbxTakiplestiklerin.Size = new System.Drawing.Size(161, 394);
            this.lbxTakiplestiklerin.TabIndex = 11;
            // 
            // lbxTakipEtmeyenler
            // 
            this.lbxTakipEtmeyenler.FormattingEnabled = true;
            this.lbxTakipEtmeyenler.ItemHeight = 15;
            this.lbxTakipEtmeyenler.Location = new System.Drawing.Point(593, 268);
            this.lbxTakipEtmeyenler.Name = "lbxTakipEtmeyenler";
            this.lbxTakipEtmeyenler.Size = new System.Drawing.Size(161, 394);
            this.lbxTakipEtmeyenler.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(424, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Takipleştiklerin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(610, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Takip Etmeyenler";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(621, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Karşılaştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(78, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(270, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(465, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(646, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 674);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxTakipEtmeyenler);
            this.Controls.Add(this.lbxTakiplestiklerin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxTakipEdilen);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxTakipciler);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.ListBox lbxTakipciler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.ListBox lbxTakipEdilen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxTakiplestiklerin;
        private System.Windows.Forms.ListBox lbxTakipEtmeyenler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

