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
        int tedarikciid = 0;
        public TedarikciIslemleri()
        {
            InitializeComponent();
        }

        private void TedarikciIslemleri_Load(object sender, EventArgs e)
        {
            CbDoldur();
            GridDoldur();
            btn_guncelle.Visible = false;
            btn_yeniEkle.Enabled = false;
        }

        private void CbDoldur()
        {
            cb_Sehir.DataSource = dm.SehirleriListele();
            cb_Sehir.ValueMember = "ID";
            cb_Sehir.DisplayMember = "Isim";
            tamamlandi = true;
            cb_Ilce.Text = "Sehir Seçiniz...";
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = dm.TedarikciListeleReader();
            dataGridView1.Columns["Sehir_ID"].Visible= dataGridView1.Columns["Ilce_ID"].Visible = dataGridView1.Columns["Silinmis"].Visible = false;
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
                FormTemizle();
                MessageBox.Show("Ekleme İşlemi Başarılı", "Bilgi");

            }
            else
            {
                MessageBox.Show("Ekleme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                //MessageBox.Show(hit.RowIndex.ToString());
                dataGridView1.ClearSelection();
                if (hit.RowIndex != -1)
                {
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    tedarikciid = Convert.ToInt32(dataGridView1.Rows[hit.RowIndex].Cells["ID"].Value);
                    contextMenuStrip1.Show(dataGridView1,new Point(e.X, e.Y));
                }
            }
        }

        private void CMSMI_Guncelle_Click(object sender, EventArgs e)
        {
            Tedarikci t = dm.TedarikciGetir(tedarikciid);
            tb_Adres.Text = t.Adres;
            tb_firmaAdi.Text = t.FirmaAdi;
            tb_Mail.Text = t.Email;
            tb_YetkiliAdi.Text = t.Yetkili;
            mtb_Telefon.Text = t.FirmaTelefon;
            cb_Sehir.SelectedValue = t.Sehir_ID;
            cb_Ilce.SelectedValue = t.Ilce_ID;
            cb_Satista.Checked = t.Durum;
            btn_guncelle.Visible = true;
            btn_yeniEkle.Enabled = true;
        }

        private void CMSMI_Sil_Click(object sender, EventArgs e)
        {
            string isim = dm.TedarikciGetir(tedarikciid).FirmaAdi;
            if (MessageBox.Show(isim+ "\nFirma Silinecek. Emin misin?","Tedarikçi Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dm.TedarikciSil(tedarikciid);
            }
           else
            {
                MessageBox.Show("Kullanıcı Silme İşlemini İptal Etti", "İptal");
            }
            GridDoldur();
        }

        private void btn_yeniEkle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Tedarikci t = dm.TedarikciGetir(tedarikciid);
            t.Adres = tb_Adres.Text;
            t.Email = tb_Mail.Text;
            t.Durum = cb_Satista.Checked;
            t.Yetkili = tb_YetkiliAdi.Text;
            t.FirmaAdi = tb_firmaAdi.Text;
            t.FirmaTelefon = mtb_Telefon.Text;
            t.Sehir_ID = Convert.ToInt32(cb_Sehir.SelectedValue);
            t.Ilce_ID = Convert.ToInt32(cb_Ilce.SelectedValue);

            if (dm.TedarikciGuncelle(t))
            {
                MessageBox.Show("Başardık Dorothy","Başarılı");
            }
            else
            {
                MessageBox.Show("Ne Oldu Anlamadık.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormTemizle();
            GridDoldur();
        }

        private void FormTemizle()
        {
            btn_guncelle.Visible = false;
            btn_yeniEkle.Enabled = false;
            tb_Adres.Text = tb_firmaAdi.Text = tb_Mail.Text = tb_YetkiliAdi.Text = "";
            mtb_Telefon.Text = "";
            CbDoldur();
        }
    }
}
