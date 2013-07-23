using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
 public   class TedarikciBS:DisposeEt
    {
         TurVek.TurVek vek;
         public TedarikciBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<TedarikciEntity> ListeGetir()
        {
            return vek.ExecuteReader<TedarikciEntity>(CommandType.Text, "select * from Tedarikci");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select * from Tedarikci");
        }
        public bool Insert(TedarikciEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into Tedarikci (TedarikciAdi,YurtIcimi,Telefon,Faks,EMail,Adres,IBAN,BankaHesapNo,EklenmeTarihi) values(@a,@b,@c,@d,@e,@f,@g,@h,@j)", entity.TedarikciAdi, entity.YurtIcimi, entity.Telefon, entity.Faks, entity.EMail, entity.Adres, entity.IBAN, entity.BankaHesapNo, entity.EklenmeTarihi) > 0 ? true : false;
        }
    }
}
