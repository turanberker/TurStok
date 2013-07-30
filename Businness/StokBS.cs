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
            return vek.GetDataTable(CommandType.Text, "Select * from Stok");
        }
        public bool Insert(StokEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "insert into Stok (UrunID,DepoID,MarkaID,TedarikciID, KalanMiktar, GelisTarihi,SonKullanmaTarihi,FaturaDetayID,OlcuBirimID) values(@a,@b,@c,@d,@e,@f,@g,@h,@J)", entity.UrunID, entity.DepoID, entity.MarkaID, entity.TedarikciID, entity.KalanMiktar, entity.GelisTarihi, entity.SonKullanmaTarihi.Value, entity.FaturaDetayID.Value, entity.OlcuBirimID) > 0 ? true : false;
        }
    }
}
