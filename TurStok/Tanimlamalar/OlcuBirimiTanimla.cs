using Businness;
using DataType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurStok.Tanimlamalar;

namespace TurStok
{
    public partial class OlcuBirimiTanimla : Form
    {
        public OlcuBirimiTanimla(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void OlcuBirimiTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.OlcuBirimiDoldur();
            grdOlcuBirimi.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("OlcuBirimiEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new OlcuBirimiEkleGuncelle(this as OlcuBirimiTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["OlcuBirimiID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["OlcuBirimiID"].Value.ToString()).FirstOrDefault();
            OlcuBirimiEntity entity = new OlcuBirimiEntity { OlcuBirimiID = Convert.ToInt64(secilen["OlcuBirimiID"]), OlcuBirimi = secilen["OlcuBirimi"].ToString() };
            Form f = anaform.Varmi("OlcuBirimiEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new OlcuBirimiEkleGuncelle(this as OlcuBirimiTanimla,entity);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
