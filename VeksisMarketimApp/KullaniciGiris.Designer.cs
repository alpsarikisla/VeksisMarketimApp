namespace VeksisMarketimApp
{
    partial class KullaniciGiris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.tb_sifre);
            this.groupBox1.Controls.Add(this.tb_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri ile Giriş";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(87, 82);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(229, 29);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(87, 56);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(229, 20);
            this.tb_sifre.TabIndex = 3;
            this.tb_sifre.Text = "1234";
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // tb_kullaniciAdi
            // 
            this.tb_kullaniciAdi.Location = new System.Drawing.Point(87, 30);
            this.tb_kullaniciAdi.Name = "tb_kullaniciAdi";
            this.tb_kullaniciAdi.Size = new System.Drawing.Size(229, 20);
            this.tb_kullaniciAdi.TabIndex = 2;
            this.tb_kullaniciAdi.Text = "alpod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 166);
            this.Controls.Add(this.groupBox1);
            this.Name = "KullaniciGiris";
            this.Text = "Kullanici Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciGiris_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_kullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}