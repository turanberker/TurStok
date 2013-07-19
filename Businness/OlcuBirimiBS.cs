using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataType;
using System.Data;

namespace Businness
{
    public class OlcuBirimiBS:DisposeEt
    {
        TurVek.TurVek vek;
        public OlcuBirimiBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<OlcuBirimiEntity> ListeGetir()
        {
             return vek.ExecuteReader<OlcuBirimiEntity>(CommandType.Text, "Select * from OlcuBirimi");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "Select * from OlcuBirimi");
        }
        public bool Insert(OlcuBirimiEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into OlcuBirimi (OlcuBirimi) values(@ob)", entity.OlcuBirimi) > 0 ? true : false;
        }
    }
}
