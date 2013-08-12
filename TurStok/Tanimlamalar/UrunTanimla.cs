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
    public partial class UrunTanimla : Form
    {
        public UrunTanimla(Main form)
        {
            InitializeComponent();
            anaform = form as Main;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        public void GridDoldur()
        {
            dt = arac.UrunDoldur();
            grdOlcuBirimi.DataSource = dt;
        }


        private void UrunTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("UrunEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new UrunEkleGuncelle(this as UrunTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["UrunID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["ID"].Value.ToString()).FirstOrDefault();
            UrunEntity entity = new UrunEntity { UrunID = Convert.ToInt64(secilen["UrunID"]), UrunAdi = secilen["UrunAdi"].ToString(), AzamiMiktar = Convert.ToDecimal(secilen["AzamiMiktar"]), KategoriID = Convert.ToInt64(secilen["KategoriID"]), OlcuBirimID=Convert.ToInt64(secilen["OlcuBirimID"]), SaklamaKosuluID=Convert.ToInt64(secilen["SaklamaKosuluID"]) };
            Form f = anaform.Varmi("UrunEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new UrunEkleGuncelle(this as UrunTanimla, entity);
            f.MdiParent = anaform;
            f.Show();
        }


    }
}
