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
    public partial class UrunIslemleri : Form
    {
        DataModel dm = new DataModel();
        public UrunIslemleri()
        {
            InitializeComponent();
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            cb_Kategori.DataSource = dm.UrunEkleKategoriGetir();
            cb_Kategori.DisplayMember = "Isim";
            cb_Kategori.ValueMember = "ID";

            cb_Marka.DataSource = dm.UrunEkleMarkaGetir();
            cb_Marka.DisplayMember = "Isim";
            cb_Marka.ValueMember = "ID";

            cb_Birim.DataSource = dm.UrunEkleBirimGetir();
            cb_Birim.DisplayMember = "Isim";
            cb_Birim.ValueMember = "ID";

            dataGridView1.DataSource = dm.UrunListele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (dm.UrunEkle(new Urun()
            {
                BarkodNo = tb_Barkod.Text,
                Aciklama = tb_Aciklama.Text,
                BirimFiyat = Convert.ToDecimal(tb_BirimFiyat.Text),
                Birim_ID = Convert.ToInt32(cb_Birim.SelectedValue),
                Kategori_ID = Convert.ToInt32(cb_Kategori.SelectedValue),
                Marka_ID = Convert.ToInt32(cb_Marka.SelectedValue),
                Durum = cb_Satista.Checked,
                Isim = tb_isim.Text,
                KDVOrani = Convert.ToInt32(cb_KDV.Text),
                Silinmis = false,
                Stok = Convert.ToDecimal(tb_Stok.Text)
            }))
            {
                Doldur();
                MessageBox.Show("Ürün Ekleme Başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Ürün Ekleme Başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
