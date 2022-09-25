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
    public partial class KullaniciGiris : Form
    {
        bool girisvar = false;
        DataModel db = new DataModel();
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                if (tb_kullaniciAdi.Text.Length >= 3 && tb_sifre.Text.Length >= 3)
                {
                    KullaniciLoginModel model = db.KullaniciGiris(tb_kullaniciAdi.Text, tb_sifre.Text);
                    if (model!= null)
                    {
                        if (model.ID != 0)
                        {
                            if (model.Durum)
                            {
                                AnaForm.LoginUser = model;
                                girisvar = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı hesabınız askıya alınmış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bulunamadı veya silinmiş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Hata Oluştu. Lütfen sistem yöneticiniz ile iletişime geçiniz","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Ve şifre en az 3 karakter olmalıdır","Hata" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Ve şifre Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (girisvar == false)
            {
                Application.Exit();
            }
        }
    }
}
