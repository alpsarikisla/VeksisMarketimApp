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
    public partial class AnaForm : Form
    {
        public static KullaniciLoginModel LoginUser;

        public AnaForm()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
            TSSL_Kullanici.Text = "Aktif Kullanıcı = " + LoginUser.KullaniciAdi;
        }
    }
}
