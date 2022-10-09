using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Tedarikçi Metotları

        public List<Tedarikci> TedarikciListeleReader()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            try
            {
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.Silinmis = 0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tedarikciler.Add(new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    });

                }
                return tedarikciler;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciEkle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Tedarikciler(FirmaAdi, Yetkili, FirmaTelefon, Email, Sehir_ID, Ilce_ID, Adres, Durum, Silinmis) VALUES(@firmaAdi, @yetkili, @firmaTelefon, @email, @sehir_ID, @ilce_ID, @adres, @durum, 0)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@firmaAdi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmaTelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public Tedarikci TedarikciGetir(int id)
        {
            try
            {
                Tedarikci t = new Tedarikci();
                cmd.CommandText = "SELECT T.ID, T.FirmaAdi, T.Yetkili, T.FirmaTelefon, T.Email, T.Sehir_ID, S.Isim, T.Ilce_ID, I.Isim, T.Adres, T.Durum FROM Tedarikciler AS T JOIN Sehirler AS S ON T.Sehir_ID = S.ID JOIN Ilceler AS I ON T.Ilce_ID = I.ID WHERE T.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t= new Tedarikci()
                    {
                        ID = reader.GetInt32(0),
                        FirmaAdi = reader.GetString(1),
                        Yetkili = reader.GetString(2),
                        FirmaTelefon = reader.GetString(3),
                        Email = reader.GetString(4),
                        Sehir_ID = reader.GetInt32(5),
                        Sehir = reader.GetString(6),
                        Ilce_ID = reader.GetInt32(7),
                        Ilce = reader.GetString(8),
                        Adres = reader.GetString(9),
                        Durum = reader.GetBoolean(10)
                    };
                }
                return t;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciGuncelle(Tedarikci model)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET FirmaAdi=@firmaadi, Yetkili =@yetkili, FirmaTelefon = @firmatelefon, Email=@email, Sehir_ID=@sehir_ID, Ilce_ID=@ilce_ID, Adres=@adres, Durum=@durum WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.ID);
                cmd.Parameters.AddWithValue("@firmaadi", model.FirmaAdi);
                cmd.Parameters.AddWithValue("@yetkili", model.Yetkili);
                cmd.Parameters.AddWithValue("@firmatelefon", model.FirmaTelefon);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@sehir_ID", model.Sehir_ID);
                cmd.Parameters.AddWithValue("@ilce_ID", model.Ilce_ID);
                cmd.Parameters.AddWithValue("@adres", model.Adres);
                cmd.Parameters.AddWithValue("@durum", model.Durum);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciSil(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE Tedarikciler SET Silinmis=1 WHERE ID= @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Şehir İlçe Metotları

        public List<Sehir> SehirleriListele()
        {
            List<Sehir> Sehirler = new List<Sehir>();
            try
            {
                cmd.CommandText = "SELECT * FROM Sehirler";
                cmd.Parameters.Clear();

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sehirler.Add(new Sehir()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return Sehirler;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Ilce> IlceleriListele(int sehirID)
        {
            List<Ilce> ilceler = new List<Ilce>();
            try
            {
                cmd.CommandText = "SELECT * FROM Ilceler WHERE SehirID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", sehirID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ilceler.Add(new Ilce()
                    {
                        ID = reader.GetInt32(0),
                        Sehir_ID = reader.GetInt32(1),
                        Isim = reader.GetString(2)
                    });
                }
                return ilceler;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region Kategori Metotları

        public List<Kategori> UrunEkleKategoriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            try
            {
                cmd.CommandText = "SELECT ID, Kategori FROM KategorilerListesi WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kategoriler.Add(new Kategori()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Marka Metotları

        public List<Marka> UrunEkleMarkaGetir()
        {
            List<Marka> markalar = new List<Marka>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Markalar WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    markalar.Add(new Marka()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return markalar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Birim Metotları

        public List<Birim> UrunEkleBirimGetir()
        {
            List<Birim> markalar = new List<Birim>();
            try
            {
                cmd.CommandText = "SELECT ID, Isim FROM Birimler WHERE Silinmis=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    markalar.Add(new Birim()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    });
                }
                return markalar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region Ürün Metotları

        public bool UrunEkle(Urun model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Urunler(BarkodNo, Kategori_ID, Marka_ID, Birim_ID, KDVOrani, Isim, Stok, Aciklama, BirimFiyat, Durum, Silinmis) VALUES(@BarkodNo, @Kategori_ID, @Marka_ID, @Birim_ID, @KDVOrani, @Isim, @Stok, @Aciklama, @BirimFiyat, @Durum, @Silinmis)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BarkodNo", model.BarkodNo);
                cmd.Parameters.AddWithValue("@Kategori_ID", model.Kategori_ID);
                cmd.Parameters.AddWithValue("@Marka_ID", model.Marka_ID);
                cmd.Parameters.AddWithValue("@Birim_ID", model.Birim_ID);
                cmd.Parameters.AddWithValue("@KDVOrani", model.KDVOrani);
                cmd.Parameters.AddWithValue("@Isim", model.Isim);
                cmd.Parameters.AddWithValue("@Stok", model.Stok);
                cmd.Parameters.AddWithValue("@Aciklama", model.Aciklama);
                cmd.Parameters.AddWithValue("@BirimFiyat", model.BirimFiyat);
                cmd.Parameters.AddWithValue("@Durum", model.Durum);
                cmd.Parameters.AddWithValue("@Silinmis", model.Silinmis);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable UrunListele()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.CommandText = "SELECT * FROM UrunListele";
                SqlDataAdapter adptr = new SqlDataAdapter(cmd);
                adptr.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion
    }
}
