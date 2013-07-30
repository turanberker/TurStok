using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class OdemeSekliBS:DisposeEt
    {
        TurVek.TurVek vek;
        public OdemeSekliBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<OdemeSekliEntity> ListeGetir()
        {
            return vek.ExecuteReader<OdemeSekliEntity>(CommandType.Text, "Select * from OdemeSekli");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "Select * from OdemeSekli");
        }
        public bool Insert(OdemeSekliEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into OdemeSekli (OdemeSekli) values(@ob)", entity.OdemeSekli) > 0 ? true : false;
        }
        public bool Update(OdemeSekliEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Update OdemeSekli set OdemeSekli=@b where OdemeSekilID=@a ", entity.OdemeSekli, entity.OdemeSekilID) > 0 ? true : false;
        }
    }
}
