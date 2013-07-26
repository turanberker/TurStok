using DataType;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Businness
{
    public class UrunBS:DisposeEt
    {
        TurVek.TurVek vek;
        public UrunBS()
        {
            vek = new TurVek.TurVek(DAL.Default.localcon.ToString());
        }
        public List<UrunEntity> ListeGetir()
        {
            return vek.ExecuteReader<UrunEntity>(CommandType.Text, "Select * from Urun");
            // return vek.GetDT(TurVek.SorguTipi.text, vek.DataTableOlustur(typeof(OlcuBirimiEntity)), "Select * from OlcuBirimi");
        }
        public DataTable JoinListe()
        {
            return vek.GetDataTable(CommandType.Text, "select u.UrunID, u.KategoriID,  u.AzamiMiktar, u.SaklamaKosuluID, u.UrunAdi,u.OlcuBirimID,ob.OlcuBirimi, k.KategoriAdi,k.MiadVarmi, sk.SaklamaKosulu from Urun U inner join Kategori k on k.KategoriID=u.KategoriID inner join SaklamaKosulu sk on sk.SaklamaKosuluID=u.SaklamaKosuluID inner join OlcuBirimi ob on u.OlcuBirimID=ob.OlcuBirimiID");
        }
        public bool Insert(UrunEntity entity)
        {
            return vek.ExecuteNonQuery(CommandType.Text, "Insert into Urun (UrunAdi, AzamiMiktar,  SaklamaKosuluID, KategoriID, OlcuBirimID ) values(@a, @b, @c, @d, @e)", entity.UrunAdi, entity.AzamiMiktar, entity.SaklamaKosuluID, entity.KategoriID,entity.OlcuBirimID) > 0 ? true : false;
        }
    }
}
