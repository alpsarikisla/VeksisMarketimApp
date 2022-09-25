namespace VeksisMarketimApp
{
    partial class TedarikciIslemleri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_firmaAdi = new System.Windows.Forms.TextBox();
            this.tb_YetkiliAdi = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.mtb_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.cb_Sehir = new System.Windows.Forms.ComboBox();
            this.cb_Ilce = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Satista = new System.Windows.Forms.CheckBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.cb_Satista);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_Ilce);
            this.groupBox1.Controls.Add(this.cb_Sehir);
            this.groupBox1.Controls.Add(this.mtb_Telefon);
            this.groupBox1.Controls.Add(this.tb_Adres);
            this.groupBox1.Controls.Add(this.tb_Mail);
            this.groupBox1.Controls.Add(this.tb_YetkiliAdi);
            this.groupBox1.Controls.Add(this.tb_firmaAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedarikçi Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firma Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yetkili Kişi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "İlçe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // tb_firmaAdi
            // 
            this.tb_firmaAdi.Location = new System.Drawing.Point(123, 33);
            this.tb_firmaAdi.Name = "tb_firmaAdi";
            this.tb_firmaAdi.Size = new System.Drawing.Size(334, 20);
            this.tb_firmaAdi.TabIndex = 1;
            // 
            // tb_YetkiliAdi
            // 
            this.tb_YetkiliAdi.Location = new System.Drawing.Point(123, 59);
            this.tb_YetkiliAdi.Name = "tb_YetkiliAdi";
            this.tb_YetkiliAdi.Size = new System.Drawing.Size(334, 20);
            this.tb_YetkiliAdi.TabIndex = 2;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(123, 85);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(334, 20);
            this.tb_Mail.TabIndex = 3;
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(567, 82);
            this.tb_Adres.Multiline = true;
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(311, 77);
            this.tb_Adres.TabIndex = 7;
            // 
            // mtb_Telefon
            // 
            this.mtb_Telefon.Location = new System.Drawing.Point(123, 111);
            this.mtb_Telefon.Mask = "(999) 000-0000";
            this.mtb_Telefon.Name = "mtb_Telefon";
            this.mtb_Telefon.Size = new System.Drawing.Size(334, 20);
            this.mtb_Telefon.TabIndex = 4;
            // 
            // cb_Sehir
            // 
            this.cb_Sehir.FormattingEnabled = true;
            this.cb_Sehir.Location = new System.Drawing.Point(567, 28);
            this.cb_Sehir.Name = "cb_Sehir";
            this.cb_Sehir.Size = new System.Drawing.Size(311, 21);
            this.cb_Sehir.TabIndex = 5;
            this.cb_Sehir.SelectedIndexChanged += new System.EventHandler(this.cb_Sehir_SelectedIndexChanged);
            // 
            // cb_Ilce
            // 
            this.cb_Ilce.FormattingEnabled = true;
            this.cb_Ilce.Location = new System.Drawing.Point(567, 55);
            this.cb_Ilce.Name = "cb_Ilce";
            this.cb_Ilce.Size = new System.Drawing.Size(311, 21);
            this.cb_Ilce.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Durum:";
            // 
            // cb_Satista
            // 
            this.cb_Satista.AutoSize = true;
            this.cb_Satista.Location = new System.Drawing.Point(123, 142);
            this.cb_Satista.Name = "cb_Satista";
            this.cb_Satista.Size = new System.Drawing.Size(75, 17);
            this.cb_Satista.TabIndex = 8;
            this.cb_Satista.Text = "Aktif Firma";
            this.cb_Satista.UseVisualStyleBackColor = true;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(773, 165);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(105, 23);
            this.btn_Ekle.TabIndex = 9;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // TedarikciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 625);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TedarikciIslemleri";
            this.Text = "Tedarikci İşlemleri";
            this.Load += new System.EventHandler(this.TedarikciIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.CheckBox cb_Satista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Ilce;
        private System.Windows.Forms.ComboBox cb_Sehir;
        private System.Windows.Forms.MaskedTextBox mtb_Telefon;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.TextBox tb_YetkiliAdi;
        private System.Windows.Forms.TextBox tb_firmaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}