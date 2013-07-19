using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    public class FaturaDetayEntity
    {
        public long FaturaDetayID { get; set; }
        public long FaturaID { get; set; }
        public long UrunID { get; set; }
        public long MarkaID { get; set; }
        public decimal SiparisVerilenMiktar { get; set; }
        public decimal? GelenMiktar { get; set; }
        public long OlcuBirimiID { get; set; }
        public decimal BirimFiyati { get; set; }
        public int KDVOrani { get; set; }
    }
}
