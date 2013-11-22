using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    public class UrunEntity
    {
        public long UrunID { get; set; }
        public long KategoriID { get; set; }

        //Asgari Miktar olacak. Yanlış yazıldı.  Miktarı azalmış ürünü alerti için kullanılıyor.
        public decimal? AzamiMiktar { get; set; }
       
        public long SaklamaKosuluID { get; set; }
        public string UrunAdi { get; set; }
        public long OlcuBirimID { get; set; }
    }
}
