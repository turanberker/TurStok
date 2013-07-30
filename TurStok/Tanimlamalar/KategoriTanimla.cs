using Businness;
using DataType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurStok.Tanimlamalar
{
    public partial class KategoriTanimla : Form
    {
        public KategoriTanimla(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void KategoriTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.KategoriDoldur();
            grdOlcuBirimi.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("Kategori Ekle Güncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new KategoriEkleGuncelle();
            f.MdiParent = anaform;
            f.Show();
        }

        private void grdOlcuBirimi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["KategoriID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            KategoriEntity entity = new KategoriEntity { KategoriID = Convert.ToInt64(secilen["KategoriID"]), KategoriAdi = secilen["KategoriAdi"].ToString(), MiadVarmi = secilen["MiadVarmi"].ToString() == "True" ? true : false };
            Form f = anaform.Varmi("Kategori Ekle Güncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new KategoriEkleGuncelle(entity);
            f.MdiParent = anaform;
            f.Show();
        }
       
    }
}
