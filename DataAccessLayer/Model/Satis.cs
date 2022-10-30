using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Satis
    {
        public Satis() { SatisTarihi = DateTime.Now; }

        public int ID { get; set; }
        public int Kullanici_ID { get; set; }
        public decimal AraToplam { get; set; }
        public decimal Toplam { get; set; }
        public decimal KDV { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}
