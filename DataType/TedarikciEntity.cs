using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    public class TedarikciEntity
    {
        public long TedarikciID { get; set; }
        public string TedarikciAdi { get; set; }
        public bool YurtIcimi { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public string IBAN { get; set; }
        public string BankaHesapNo { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
