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
        public decimal? AzamiMiktar { get; set; }
       
        public long SaklamaKosuluID { get; set; }
        public string UrunAdi { get; set; }
    }
}
