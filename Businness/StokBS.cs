using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class StokBS : DisposeEt
    {
        TurVek.TurVek vek;
        public StokBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<StokEntity> ListeGetir()
        {
            return vek.ExecuteReader<StokEntity>(CommandType.Text, "Select * from Stok");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select s.StokID,  k.KategoriAdi, u.UrunAdi,o.OlcuBirimi,m.MarkaAdi,t.TedarikciAdi, s.SonKullanmaTarihi, s.KalanMiktar, s.GelisTarihi,   k.MiadVarmi , d.DepoID, d.DepoAdi,  u.AzamiMiktar, s.FaturaDetayID  from Stok s inner join Urun u on u.UrunID=s.UrunID inner join Depo d on s.DepoID=d.DepoID inner join Marka m on s.MarkaID=m.MarkaID inner join Tedarikci t on t.TedarikciID=s.TedarikciID inner join OlcuBirimi o on s.OlcuBirimID=o.OlcuBirimiID inner join Kategori k on k.KategoriID=u.KategoriID where KalanMiktar>0  order by s.SonKullanmaTarihi asc ");
        }
        public bool Insert(StokEntity entity)
        {
            if (entity.SonKullanmaTarihi.HasValue && entity.FaturaDetayID.HasValue)
                return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,SonKullanmaTarihi,FaturaDetayID,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g,@h,@J)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi, entity.SonKullanmaTarihi, entity.FaturaDetayID, entity.OlcuBirimID) > 0 ? true : false;
            else if (entity.SonKullanmaTarihi.HasValue && !entity.FaturaDetayID.HasValue)
                return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,SonKullanmaTarihi,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g,@h)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi, entity.SonKullanmaTarihi, entity.OlcuBirimID) > 0 ? true : false;
            else if (!entity.SonKullanmaTarihi.HasValue && !entity.FaturaDetayID.HasValue)
                return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi, entity.OlcuBirimID) > 0 ? true : false;
            else if (!entity.SonKullanmaTarihi.HasValue && entity.FaturaDetayID.HasValue)
                return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,FaturaDetayID,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g,@h)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi,  entity.FaturaDetayID, entity.OlcuBirimID) > 0 ? true : false;
            else return false;

        }
        public bool DepodanCik(long StokID, decimal KalanMiktar)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "update Stok set KalanMiktar=@kalan  where StokID=@a ", KalanMiktar, StokID) > 0 ? true : false;
        }
        public bool DepoDegistir(long StokID, long DepoID)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "update Stok set DepoID=@DepoID  where StokID=@a ", DepoID, StokID) > 0 ? true : false;
        }

    }
}
