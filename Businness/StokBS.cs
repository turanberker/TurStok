using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class StokBS:DisposeEt
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
            return vek.GetDataTable(CommandType.Text, "select s.StokID, s.KalanMiktar, s.GelisTarihi,  u.UrunAdi,  k.KategoriAdi, k.MiadVarmi , s.SonKullanmaTarihi ,d.DepoID, d.DepoAdi, m.MarkaAdi, t.TedarikciAdi,o.OlcuBirimi,u.AzamiMiktar, s.FaturaDetayID  from Stok s inner join Urun u on u.UrunID=s.UrunID inner join Depo d on s.DepoID=d.DepoID inner join Marka m on s.MarkaID=m.MarkaID inner join Tedarikci t on t.TedarikciID=s.TedarikciID inner join OlcuBirimi o on s.OlcuBirimID=o.OlcuBirimiID inner join Kategori k on k.KategoriID=u.KategoriID where KalanMiktar>0  order by s.SonKullanmaTarihi asc ");
        }
        public bool Insert(StokEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,SonKullanmaTarihi,FaturaDetayID,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g,@h,@J)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi, entity.SonKullanmaTarihi.Value, entity.FaturaDetayID.Value, entity.OlcuBirimID) > 0 ? true : false;
        }
        public bool DepodanCik(long StokID, decimal KalanMiktar)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "update Stok set KalanMiktar=@kalan  where StokID=@a ", KalanMiktar,StokID) > 0 ? true : false;
        }
        public bool DepoDegistir(long StokID, long DepoID)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "update Stok set DepoID=@DepoID  where StokID=@a ", DepoID, StokID) > 0 ? true : false;
        }
        
    }
}
