using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
   public  class FaturaBS
    {
       TurVek.TurVek vek;
       public FaturaBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<FaturaEntity> ListeGetir()
        {
             return vek.ExecuteReader<FaturaEntity>(CommandType.Text, "select * from Fatura f ");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select f.FaturaID,f.FaturaNo,f.TedarikciID,f.SiparisTarihi,f.Aciklama,f.ParaBirimiID,f.Kur,f.ODemeYapildimi,t.TedarikciAdi,p.ParaBirimi from Fatura f inner join Tedarikci t on t.TedarikciID=f.TedarikciID inner join ParaBirimi p on p.ParaBirimiID=f.ParaBirimiID");
        }
        public long Insert(FaturaEntity entity)
        {
            return Convert.ToInt64(vek.ExecuteScalar(CommandType.Text, "Insert into Fatura (FaturaNo,TedarikciID,SiparisTarihi,Aciklama,ParaBirimiID,Kur,ODemeYapildimi) values(@a,@bi,@sip,@ac,@pb,@kur,1) Select @@Identity", entity.FaturaNo,entity.TedarikciID,entity.SiparisTarihi,entity.Aciklama,entity.ParaBirimiID, entity.Kur));
        }
    }
}
