using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataType
{
    public class FaturaEntity
    {
        public long FaturaID { get; set; }
        public string FaturaNo { get; set; }
        public long TedarikciID { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string Aciklama { get; set; }
        public long ParaBirimiID { get; set; }
        public decimal? Kur { get; set; }
        public Boolean OdemeYapildimi { get; set; }
        public long OdemeSekliID { get; set; }
    }
}
