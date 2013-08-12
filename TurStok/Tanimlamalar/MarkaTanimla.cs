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
using TurStok.Tanimlamalar;

namespace TurStok
{
    public partial class MarkaTanimla : Form
    {
        public MarkaTanimla(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void MarkaTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.MarkaDoldur();
            grdOlcuBirimi.DataSource = dt;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("MarkaEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new MarkaEkleGuncelle(this as MarkaTanimla);
            f.MdiParent = anaform;
            f.Show();
        }
        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["MarkaID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            MarkaEntity entity = new MarkaEntity { MarkaID = Convert.ToInt64(secilen["MarkaID"]), MarkaAdi = secilen["MarkaAdi"].ToString()};
            Form f = anaform.Varmi("MarkaEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new MarkaEkleGuncelle(this as MarkaTanimla,entity);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
