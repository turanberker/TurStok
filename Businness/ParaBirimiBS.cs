using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
   public class ParaBirimiBS:DisposeEt
    {
        TurVek.TurVek vek;
        public ParaBirimiBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<ParaBirimiEntity> ListeGetir()
        {
            return vek.ExecuteReader<ParaBirimiEntity>(CommandType.Text, "Select * from ParaBirimi");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "Select * from ParaBirimi");
        }
        public bool Insert(ParaBirimiEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into ParaBirimi (ParaBirimi) values(@ob)", entity.ParaBirimi) > 0 ? true : false;
        }
        public bool Update(ParaBirimiEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Update ParaBirimi set ParaBirimi=@b  where ParaBirimiID=@a ", entity.ParaBirimi, entity.ParaBirimiID) > 0 ? true : false;
        }
    }
}
