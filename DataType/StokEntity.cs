using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    public class StokEntity
    {
        public long StokID { get; set; }
        public long UrunID { get; set; }
        public long DepoID { get; set; }
        public long MarkaID { get; set; }
        public long TedarikciID { get; set; }
        public decimal KalanMiktar { get; set; }
        public DateTime GelisTarihi { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }
        public long? IlgiliFaturaID { get; set; }
    }
}
