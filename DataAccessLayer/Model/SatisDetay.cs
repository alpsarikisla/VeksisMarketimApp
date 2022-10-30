using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class SatisDetay
    {
        public string ID { get; set; }
        public int Satis_ID { get; set; }
        public int Urun_ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public int KDVOrani { get; set; }
        public decimal AraToplam { get; set; }
        public decimal Toplam { get; set; }
        public decimal KDV { get; set; }
    }
}
