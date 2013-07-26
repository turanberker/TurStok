using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{

    public class FaturaBS:DisposeEt
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
            return vek.GetDataTable(CommandType.Text, "select f.FaturaID,f.FaturaNo,f.TedarikciID,f.FaturaTarihi, f.Aciklama,f.ParaBirimiID,f.Kur, f.OdemeYapildimi, t.TedarikciAdi,p.ParaBirimi, f.OdemeSekliID,od.OdemeSekli, (select SUM(fd.SiparisVerilenMiktar*fd.BirimFiyati*(100+fd.KDVOrani)/100) from FaturaDetay fd where fd.FaturaID=f.FaturaID) FaturaTutari from Fatura f inner join Tedarikci t on t.TedarikciID=f.TedarikciID inner join ParaBirimi p on p.ParaBirimiID=f.ParaBirimiID inner join OdemeSekli od on od.OdemeSekilID=f.OdemeSekliID");
        }
        public long Insert(FaturaEntity entity)
        {
            return Convert.ToInt64(vek.ExecuteScalar(CommandType.Text, "Insert into Fatura (FaturaNo,TedarikciID,FaturaTarihi,Aciklama,ParaBirimiID,Kur,ODemeYapildimi, OdemeSekliID) values(@a,@bi,@sip,@ac,@pb,@kur,0,@oId) Select @@Identity", entity.FaturaNo, entity.TedarikciID, entity.FaturaTarihi, entity.Aciklama, entity.ParaBirimiID, entity.Kur, entity.OdemeSekliID));
        }
        public bool OdemeYap(long FaturaID)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "update Fatura set OdemeYapildimi=1 where FaturaID=@ID", FaturaID) > 0 ? true : false;
        }
    }
}
