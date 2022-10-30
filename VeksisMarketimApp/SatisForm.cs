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
    public partial class SatisForm : Form
    {
        DataModel dm = new DataModel();
        List<SatisDetay> SatilanUrunler = new List<SatisDetay>();
        decimal toplam;
        decimal aratoplam;
        decimal kdv;
        public SatisForm()
        {
            InitializeComponent();

            toplam = aratoplam = kdv = 0;
        }

        private void tb_Barkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Urun u = dm.UrunGetir(tb_Barkod.Text);
                SatisDetay sd = new SatisDetay();
                sd.ID = Guid.NewGuid().ToString();
                sd.Urun_ID = u.ID;
                sd.UrunAdi = u.Isim;
                sd.Adet = nud_adet.Value;
                sd.BirimFiyat = u.BirimFiyat;
                sd.AraToplam = sd.Adet * sd.BirimFiyat;
                sd.KDVOrani = u.KDVOrani;
                sd.KDV = sd.AraToplam * (Convert.ToDecimal(u.KDVOrani) / 100);
                sd.Toplam = sd.AraToplam + sd.KDV;
               
                int index = -1;
                for (int i = 0; i < SatilanUrunler.Count; i++)
                {
                    if (SatilanUrunler[i].Urun_ID == u.ID)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    SatilanUrunler[index].Adet = SatilanUrunler[index].Adet + nud_adet.Value;
                    SatilanUrunler[index].AraToplam += nud_adet.Value * u.BirimFiyat;
                    SatilanUrunler[index].AraToplam += nud_adet.Value * u.BirimFiyat + (aratoplam * (u.KDVOrani / 100));
                }
                else
                {
                    SatilanUrunler.Add(sd);
                }
                toplam += sd.Toplam;
                lbl_birim.Text = Convert.ToDouble(sd.BirimFiyat).ToString();
                kdv += sd.KDV;
                aratoplam += sd.AraToplam;
                tb_Barkod.Text = "";
                GridDoldur();
            }
        }

        private void GridDoldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SatilanUrunler;
            dataGridView1.Columns["Satis_ID"].Visible = false;
            dataGridView1.Columns["Urun_ID"].Visible = false;
            lbl_toplam.Text = Convert.ToDouble(toplam).ToString() + " TL";
            lbl_aratoplam.Text = Convert.ToDouble(aratoplam).ToString() + " TL";
            lbl_KDV.Text = Convert.ToDouble(kdv).ToString() + " TL";
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            Satis s = new Satis();
            s.Kullanici_ID = AnaForm.LoginUser.ID;
            s.AraToplam = aratoplam;
            s.KDV = kdv;
            s.Toplam = toplam;
            for (int i = 0; i < SatilanUrunler.Count; i++)
            {

            }
            int id = dm.satisEkle(s);
            if (id != -1)
            {

                for (int i = 0; i < SatilanUrunler.Count; i++)
                {
                    SatilanUrunler[i].Satis_ID = id;
                }

                dm.SatisDetayEkle(SatilanUrunler);
                dataGridView1.DataSource = null;
                SatilanUrunler = new List<SatisDetay>();
                toplam = aratoplam = kdv = 0;
                GridDoldur();

                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Hata Var");
            }
        }
    }
}
