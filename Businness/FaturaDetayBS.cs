using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
   public  class FaturaDetayBS:DisposeEt
    {
        TurVek.TurVek vek;
        public FaturaDetayBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public bool Insert(FaturaDetayEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "insert into FaturaDetay(FaturaID, UrunID, MarkaID, SiparisVerilenMiktar, GelenMiktar,  BirimFiyati, KDVOrani, TeslimAlindimi)values(@a,@b,@c,@d,@e,@f,@g,@h)", entity.FaturaID, entity.UrunID, entity.MarkaID, entity.SiparisVerilenMiktar, entity.GelenMiktar.Value,  entity.BirimFiyati, entity.KDVOrani, entity.TeslimAlindimi) > 0 ? true : false;
        }
        public DataTable JoinListe(long FaturaID)
        {
            return vek.GetDataTable(CommandType.Text, "select fd.FaturaDetayID,fd.FaturaID, fd.UrunID, fd.MarkaID, fd.SiparisVerilenMiktar, fd.GelenMiktar, fd.BirimFiyati, fd.KDVOrani, fd.TeslimAlindimi, fd.SiparisVerilenMiktar*fd.BirimFiyati ToplamFiyat,fd.BirimFiyati*fd.SiparisVerilenMiktar*fd.KDVOrani/100 KDVTutari, fd.BirimFiyati*fd.SiparisVerilenMiktar*(100+fd.KDVOrani)/100 KDVDahil,u.UrunAdi, m.MarkaAdi, ob.OlcuBirimi from FaturaDetay fd inner join Urun u on u.UrunID=fd.UrunID inner join Marka m on m.MarkaID=fd.MarkaID inner join OlcuBirimi ob on ob.OlcuBirimiID=u.OlcuBirimID where fd.FaturaID=@Id", FaturaID);
        }
        public DataTable JoinListeforStokGiris()
        {
            return vek.GetDataTable(CommandType.Text, "select fd.FaturaDetayID, fd.UrunID, fd.MarkaID, fd.SiparisVerilenMiktar,  u.UrunAdi, m.MarkaAdi, ob.OlcuBirimi, k.MiadVarmi, f.TedarikciID,ob.OlcuBirimiID from FaturaDetay fd inner join Fatura f on f.FaturaID=fd.FaturaID inner join Urun u on u.UrunID=fd.UrunID inner join Marka m on m.MarkaID=fd.MarkaID inner join OlcuBirimi ob on ob.OlcuBirimiID=u.OlcuBirimID inner join Kategori k on k.KategoriID=u.KategoriID where fd.TeslimAlindimi=0");
        }
        public bool TeslimAl(long FaturaDetayID, decimal gelen)
        {
            return vek.ExecuteNonQuery(CommandType.Text,"update FaturaDetay set GelenMiktar=@gelen, TeslimAlindimi=1 where FaturaDetayID=@ID", gelen, FaturaDetayID) > 0 ? true : false;
        }
    }
}
