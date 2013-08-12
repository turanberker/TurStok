using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Businness;
using System.Windows.Forms;
using System.Data;
using DataType;

namespace TurStok.Helper
{
    class GridDoldurucular
    {
        DataTable dt=new DataTable();
        public DataTable FaturaDetayDoldur(long FaturaID)
        {
            using (FaturaDetayBS bs = new FaturaDetayBS())
            {
                dt = bs.JoinListe(FaturaID);
            }
            return dt;
        }
        public DataTable FaturaDoldur()
        {
            using (FaturaBS bs = new FaturaBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable OlcuBirimiDoldur()
        {
            using (OlcuBirimiBS bs = new OlcuBirimiBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable MarkaDoldur()
        {
            using (MarkaBS bs = new MarkaBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable KategoriDoldur()
        {
            using (KategoriBS bs = new KategoriBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable DepoDoldur()
        {
            using (DepoBS bs = new DepoBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable ParaBirimiDoldur()
        {
            using(ParaBirimiBS bs=new ParaBirimiBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable SaklamaKosuluDoldur()
        {
            using(SaklamaKosuluBS bs=new SaklamaKosuluBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable TedarikcileriDoldur()
        {
            using (TedarikciBS bs = new TedarikciBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable OdemeSekliDoldur()
        {
            using (OdemeSekliBS bs = new OdemeSekliBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable UrunDoldur()
        {
            using (UrunBS bs = new UrunBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable BeklenenMalzemeleriDoldur()
        {
            using (FaturaDetayBS bs = new FaturaDetayBS())
            {
                dt = bs.JoinListeforStokGiris();
            }
            return dt;
        }
        public DataTable StoguGetir()
        {
            using (StokBS bs = new StokBS())
            {
                dt = bs.JoinListe();
            }
            return dt;
        }
        public DataTable FaturaDetayDoldurbyFaturaDetayID(long FaturaDetayID)
        {
            using (FaturaDetayBS bs = new FaturaDetayBS())
            {
                dt = bs.JoinListebyFaturaDetayID(FaturaDetayID);
            }
            return dt;
        }
        public DataTable FaturDoldurbyFaturaDetayID(long FaturaDetayID)
        {
            using (FaturaBS bs = new FaturaBS())
            {
                dt = bs.FaturaGetirbyFaturaDetayID(FaturaDetayID);
            }
            return dt;
        }
    }
}
