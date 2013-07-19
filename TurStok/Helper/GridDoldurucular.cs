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
        DataTable dt = new DataTable();
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
    }
}
