using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class DepoBS:DisposeEt
    {
         TurVek.TurVek vek;
         public DepoBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<DepoEntity> ListeGetir()
        {
            return vek.ExecuteReader<DepoEntity>(CommandType.Text, "select * from Depo");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select * from Depo");
        }
        public bool Insert(DepoEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into Depo (DepoAdi) values(@ob)", entity.DepoAdi) > 0 ? true : false;
        }
    }
}
