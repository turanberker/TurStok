using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class KategoriBS:DisposeEt
    {
         TurVek.TurVek vek;
         public KategoriBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<KategoriEntity> ListeGetir()
        {
            return vek.ExecuteReader<KategoriEntity>(CommandType.Text, "select * from Kategori");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select * from Kategori");
        }
        public bool Insert(KategoriEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into Kategori (KategoriAdi, MiadVarmi) values(@ob, @mi)", entity.KategoriAdi, entity.MiadVarmi) > 0 ? true : false;
        }
        public bool Update(KategoriEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Update Kategori set KategoriAdi=@b, MiadVarmi=@c where KategoriID=@a ",  entity.KategoriAdi, entity.MiadVarmi,entity.KategoriID) > 0 ? true : false;
        }
    }
}
