using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStrLive);
            cmd = con.CreateCommand();
        }

        #region Kullanıcı Metotları

        public KullaniciLoginModel KullaniciGiris(string kullaniciAdi, string sifre)
        {
            try
            {
                KullaniciLoginModel k = new KullaniciLoginModel();
                cmd.CommandText = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi != 0)
                {
                    cmd.CommandText = "SELECT ID,Isim,Soyisim,KullaniciAdi,Durum FROM Kullanicilar WHERE KullaniciAdi=@id AND Sifre=@sifre AND Silinmis=0";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        k.ID = reader.GetInt32(0);
                        k.Isim = reader.GetString(1);
                        k.Soyisim = reader.GetString(2);
                        k.KullaniciAdi = reader.GetString(3);
                        k.Durum = reader.GetBoolean(4);
                    }
                }
                return k;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
