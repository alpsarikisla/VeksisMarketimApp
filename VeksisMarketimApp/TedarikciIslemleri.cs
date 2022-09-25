using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeksisMarketimApp
{
    public partial class TedarikciIslemleri : Form
    {
        DataModel dm = new DataModel();
        bool tamamlandi = false;
        public TedarikciIslemleri()
        {
            InitializeComponent();
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            cb_Sehir.DataSource = dm.SehirleriListele();
            cb_Sehir.ValueMember = "ID";
            cb_Sehir.DisplayMember = "Isim";
            tamamlandi = true;
            cb_Ilce.Text = "Sehir Seçiniz...";
            GridDoldur();
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.TedarikciListeleReader();
            dataGridView1.Columns["Sehir_ID"].Visible= dataGridView1.Columns["Ilce_ID"].Visible = false;
            dataGridView1.Columns["FirmaAdi"].Width = 300;
        }

        private void cb_Sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tamamlandi == true)
            {
                int id = Convert.ToInt32(cb_Sehir.SelectedValue);
                cb_Ilce.DataSource = dm.IlceleriListele(id);
                cb_Ilce.ValueMember = "ID";
                cb_Ilce.DisplayMember = "Isim";
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tedarikci tt = new Tedarikci()
            {
                FirmaAdi = tb_firmaAdi.Text,
                Yetkili = tb_YetkiliAdi.Text,
                FirmaTelefon = mtb_Telefon.Text,
                Email = tb_Mail.Text,
                Sehir_ID = Convert.ToInt32(cb_Sehir.SelectedValue),
                Ilce_ID = Convert.ToInt32(cb_Ilce.SelectedValue),
                Adres = tb_Adres.Text,
                Durum = cb_Satista.Checked,
            };
            if (dm.TedarikciEkle(tt))
            {
                GridDoldur();
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");

            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
