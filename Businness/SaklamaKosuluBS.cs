using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
   public class SaklamaKosuluBS:DisposeEt
    {
         TurVek.TurVek vek;
         public SaklamaKosuluBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<SaklamaKosuluEntity> ListeGetir()
        {
            return vek.ExecuteReader<SaklamaKosuluEntity>(CommandType.Text, "select * from SaklamaKosulu");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select * from SaklamaKosulu");
        }
        public bool Insert(SaklamaKosuluEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into SaklamaKosulu (SaklamaKosulu) values(@ob)", entity.SaklamaKosuluAdi) > 0 ? true : false;
        }
        public bool Update(SaklamaKosuluEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Update SaklamaKosulu set SaklamaKosulu=@b  where SaklamaKosuluID=@a ", entity.SaklamaKosuluAdi, entity.SaklamaKosuluID) > 0 ? true : false;
        }
    }
}
