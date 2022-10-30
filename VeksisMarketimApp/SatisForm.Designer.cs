namespace VeksisMarketimApp
{
    partial class SatisForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Barkod = new System.Windows.Forms.TextBox();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.lbl_birim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_KDV = new System.Windows.Forms.Label();
            this.lbl_aratoplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Satis = new System.Windows.Forms.Button();
            this.nud_adet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_Barkod
            // 
            this.tb_Barkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Barkod.Location = new System.Drawing.Point(12, 63);
            this.tb_Barkod.Name = "tb_Barkod";
            this.tb_Barkod.Size = new System.Drawing.Size(301, 38);
            this.tb_Barkod.TabIndex = 1;
            this.tb_Barkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Barkod_KeyDown);
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_toplam.Location = new System.Drawing.Point(160, 31);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(138, 46);
            this.lbl_toplam.TabIndex = 2;
            this.lbl_toplam.Text = "0,0 TL";
            // 
            // lbl_birim
            // 
            this.lbl_birim.AutoSize = true;
            this.lbl_birim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birim.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_birim.Location = new System.Drawing.Point(162, 85);
            this.lbl_birim.Name = "lbl_birim";
            this.lbl_birim.Size = new System.Drawing.Size(91, 31);
            this.lbl_birim.TabIndex = 2;
            this.lbl_birim.Text = "0,0 TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barkod No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_toplam);
            this.groupBox1.Controls.Add(this.lbl_aratoplam);
            this.groupBox1.Controls.Add(this.lbl_KDV);
            this.groupBox1.Controls.Add(this.lbl_birim);
            this.groupBox1.Location = new System.Drawing.Point(15, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tutarlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Birim Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "KDV Tutarı";
            // 
            // lbl_KDV
            // 
            this.lbl_KDV.AutoSize = true;
            this.lbl_KDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KDV.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_KDV.Location = new System.Drawing.Point(162, 172);
            this.lbl_KDV.Name = "lbl_KDV";
            this.lbl_KDV.Size = new System.Drawing.Size(91, 31);
            this.lbl_KDV.TabIndex = 2;
            this.lbl_KDV.Text = "0,0 TL";
            // 
            // lbl_aratoplam
            // 
            this.lbl_aratoplam.AutoSize = true;
            this.lbl_aratoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aratoplam.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_aratoplam.Location = new System.Drawing.Point(162, 127);
            this.lbl_aratoplam.Name = "lbl_aratoplam";
            this.lbl_aratoplam.Size = new System.Drawing.Size(91, 31);
            this.lbl_aratoplam.TabIndex = 2;
            this.lbl_aratoplam.Text = "0,0 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(21, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ara Toplam:";
            // 
            // btn_Satis
            // 
            this.btn_Satis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Satis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Satis.Location = new System.Drawing.Point(783, 334);
            this.btn_Satis.Name = "btn_Satis";
            this.btn_Satis.Size = new System.Drawing.Size(181, 49);
            this.btn_Satis.TabIndex = 5;
            this.btn_Satis.Text = "Satış Tamamla";
            this.btn_Satis.UseVisualStyleBackColor = true;
            this.btn_Satis.Click += new System.EventHandler(this.btn_Satis_Click);
            // 
            // nud_adet
            // 
            this.nud_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_adet.Location = new System.Drawing.Point(319, 63);
            this.nud_adet.Name = "nud_adet";
            this.nud_adet.Size = new System.Drawing.Size(82, 38);
            this.nud_adet.TabIndex = 6;
            this.nud_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 599);
            this.Controls.Add(this.nud_adet);
            this.Controls.Add(this.btn_Satis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Barkod);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Barkod;
        private System.Windows.Forms.Label lbl_toplam;
        private System.Windows.Forms.Label lbl_birim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_aratoplam;
        private System.Windows.Forms.Label lbl_KDV;
        private System.Windows.Forms.Button btn_Satis;
        private System.Windows.Forms.NumericUpDown nud_adet;
    }
}