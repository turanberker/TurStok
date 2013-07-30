using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class MarkaBS:DisposeEt
    {
        TurVek.TurVek vek;
        public MarkaBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<MarkaEntity> ListeGetir()
        {
             return vek.ExecuteReader<MarkaEntity>(CommandType.Text, "Select * from Marka");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "Select * from Marka");
        }
        public bool Insert(MarkaEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into Marka (MarkaAdi) values(@ob)", entity.MarkaAdi) > 0 ? true : false;
        }
        public bool Update(MarkaEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Update Marka set MarkaAdi=@b where MarkaID=@a ", entity.MarkaAdi, entity.MarkaID) > 0 ? true : false;
        }
    }
}
