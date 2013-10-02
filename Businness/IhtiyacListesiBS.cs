using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class IhtiyacListesiBS : DisposeEt
    {
        TurVek.TurVek vek;
        public IhtiyacListesiBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<IhtiyacListesiEntity> ListeGetir()
        {
            return vek.ExecuteReader<IhtiyacListesiEntity>(CommandType.Text, "select * from IhtiyacListesi order by Tarih desc");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select il.UrunID, u.UrunAdi, k.KategoriAdi, il.Tarih from IhtiyacListesi il inner join Urun u on u.UrunID=il.UrunID inner join Kategori k on k.KategoriID=u.UrunID order by Tarih desc");
        }
        public bool Insert(IhtiyacListesiEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into IhtiyacListesi (urunID, Tarih) values(@UrunID, @Tarih)", entity.UrunID, entity.Tarih) > 0 ? true : false;
        }
        public bool Delete(IhtiyacListesiEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "delete from IhtiyacListesi where UrunID=@UrunID", entity.UrunID) > 0 ? true : false;
        }
    }
}
