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
    public partial class DepoTanimla : Form
    {
        public DepoTanimla(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void DepoTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.DepoDoldur();
            grdOlcuBirimi.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("DepoEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new DepoEkleGuncelle(this as DepoTanimla);
            f.MdiParent = anaform;
            f.Show();
        }
        private void grdOlcuBirimi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["DepoID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            DepoEntity entity = new DepoEntity { DepoID = Convert.ToInt64(secilen["DepoID"]), DepoAdi = secilen["DepoAdi"].ToString()};
            Form f = anaform.Varmi("DepoEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new DepoEkleGuncelle(this as DepoTanimla, entity);
            f.MdiParent = anaform;
            f.Show();
        }

    }
}
