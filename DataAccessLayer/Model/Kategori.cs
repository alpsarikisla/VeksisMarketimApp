using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Kategori
    {
        public Kategori() { Durum = true; Silinmis = false; }

        public int ID { get; set; }
        public int UstKategori_ID { get; set; }
        public string UstKategoriIsim { get; set; }
        public string Isim { get; set; }
        public bool Durum { get; set; }
        public bool Silinmis { get; set; }
    }
}
