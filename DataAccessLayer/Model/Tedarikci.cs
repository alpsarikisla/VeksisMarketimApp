using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Tedarikci
    {
        public int ID { get; set; }
        public string FirmaAdi { get; set; }
        public string Yetkili { get; set; }
        public string Email { get; set; }
        public string FirmaTelefon { get; set; }
        public int Sehir_ID { get; set; }
        public string Sehir { get; set; }
        public int Ilce_ID { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        public bool Durum { get; set; }
        public bool Silinmis { get; set; }
    }
}
