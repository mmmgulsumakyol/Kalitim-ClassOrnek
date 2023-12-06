namespace WindowsFormsApp8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.sayi3 = new System.Windows.Forms.TextBox();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sayilarToplami = new System.Windows.Forms.Label();
            this.ToplamSayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrtSAyi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI GİRİNİZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI GİRİNİZ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SAYI GİRİNİZ:";
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(158, 80);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 3;
            // 
            // sayi3
            // 
            this.sayi3.Location = new System.Drawing.Point(158, 166);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(100, 20);
            this.sayi3.TabIndex = 4;
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(158, 123);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 5;
            // 
            // sayilarToplami
            // 
            this.sayilarToplami.AutoSize = true;
            this.sayilarToplami.Location = new System.Drawing.Point(75, 232);
            this.sayilarToplami.Name = "sayilarToplami";
            this.sayilarToplami.Size = new System.Drawing.Size(119, 13);
            this.sayilarToplami.TabIndex = 6;
            this.sayilarToplami.Text = "SAYILARIN TOPLAMI :";
            // 
            // ToplamSayi
            // 
            this.ToplamSayi.AutoSize = true;
            this.ToplamSayi.Location = new System.Drawing.Point(200, 232);
            this.ToplamSayi.Name = "ToplamSayi";
            this.ToplamSayi.Size = new System.Drawing.Size(0, 13);
            this.ToplamSayi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SAYILARIN ORTALAMASI:";
            // 
            // OrtSAyi
            // 
            this.OrtSAyi.AutoSize = true;
            this.OrtSAyi.Location = new System.Drawing.Point(194, 262);
            this.OrtSAyi.Name = "OrtSAyi";
            this.OrtSAyi.Size = new System.Drawing.Size(0, 13);
            this.OrtSAyi.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(302, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "İŞLEMİ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(302, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "TEMİZLEME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrtSAyi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToplamSayi);
            this.Controls.Add(this.sayilarToplami);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi1);
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
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.TextBox sayi3;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.Label sayilarToplami;
        private System.Windows.Forms.Label ToplamSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OrtSAyi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

