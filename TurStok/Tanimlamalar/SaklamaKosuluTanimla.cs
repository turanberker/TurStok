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
    public partial class SaklamaKosuluTanimla : Form
    {
        public SaklamaKosuluTanimla()
        {
            InitializeComponent();
        }
        public SaklamaKosuluTanimla(Main form)
        {
            InitializeComponent();
            anaform = form as Main;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("SaklamaKosuluEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new SaklamaKosuluEkleGuncelle(this as SaklamaKosuluTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

        private void SaklamaKosuluTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.SaklamaKosuluDoldur();
            grdOlcuBirimi.DataSource = dt;
        }

        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["SaklamaKosuluID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            SaklamaKosuluEntity entity = new SaklamaKosuluEntity { SaklamaKosuluID = Convert.ToInt64(secilen["SaklamaKosuluID"]), SaklamaKosuluAdi = secilen["SaklamaKosulu"].ToString() };
            Form f = anaform.Varmi("SaklamaKosuluEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new SaklamaKosuluEkleGuncelle(this as SaklamaKosuluTanimla,entity);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
