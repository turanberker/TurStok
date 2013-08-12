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
    public partial class ParaBirimiTanimla : Form
    {
        public ParaBirimiTanimla()
        {
            InitializeComponent();
        }
        public ParaBirimiTanimla(Main form)
        {
            InitializeComponent();
            anaform = form as Main;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void ParaBirimiTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.ParaBirimiDoldur();
            grdOlcuBirimi.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("ParaBirimiEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new ParaBirimiEkleGuncelle(this as ParaBirimiTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["ParaBirimiID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            ParaBirimiEntity entity = new ParaBirimiEntity { ParaBirimiID = Convert.ToInt64(secilen["ParaBirimiID"]), ParaBirimi = secilen["ParaBirimi"].ToString() };
            Form f = anaform.Varmi("ParaBirimiEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new ParaBirimiEkleGuncelle(this as ParaBirimiTanimla, entity);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
