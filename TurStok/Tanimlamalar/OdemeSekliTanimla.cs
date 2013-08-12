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
    public partial class OdemeSekliTanimla : Form
    {
        public OdemeSekliTanimla(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        public void GridDoldur()
        {
            dt = arac.OdemeSekliDoldur();
            grdOlcuBirimi.DataSource = dt;
          
        }
        private void OdemeSekliTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("OdemeSekliEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new OdemeSekliEkleGuncelle(this as OdemeSekliTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["OdemeSekilID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            OdemeSekliEntity entity = new OdemeSekliEntity { OdemeSekilID = Convert.ToInt64(secilen["OdemeSekilID"]), OdemeSekli = secilen["OdemeSekli"].ToString() };
            Form f = anaform.Varmi("OdemeSekliEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new OdemeSekliEkleGuncelle(this as OdemeSekliTanimla,entity);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
