using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurStok.Islemler;

namespace TurStok
{
    public partial class Stok : Form
    {
        public Stok(Main Form, DataTable Stok)
        {
            InitializeComponent();
            anaform = Form;
            using (DataView dw = new DataView(Stok))
            {
                dw.Sort = "SonKullanmaTarihi ASC";
                Stok = dw.ToTable();
            }
            grdStok.DataSource = Stok;
        }
        private Main anaform;
        
        private void grdStok_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string asd = grdStok.Rows[e.RowIndex].Cells["StokID"].Value.ToString();
            DataRow secilen = anaform.StokDataTable.Rows.Cast<DataRow>().Where(x => x["StokID"].ToString() == grdStok.Rows[e.RowIndex].Cells["StokID"].Value.ToString()).FirstOrDefault();
            Form f =anaform.Varmi("StokDetay");
            if (f == null)
            {
                f = new StokDetay(anaform, secilen);
                f.MdiParent = anaform;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (!string.IsNullOrEmpty(txtAdi.Text))
            {
                using (DataView dw = new DataView(anaform.StokDataTable))
                {
                    dw.RowFilter = string.Format(" UrunAdi like '%{0}%'", txtAdi.Text);
                    dt = dw.ToTable();
                }
            }
            else
            {
                dt = anaform.StokDataTable;
            }
            if (!string.IsNullOrEmpty(txtKategori.Text))
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" KategoriAdi like '%{0}%'", txtKategori.Text);
                    dt = dw.ToTable();
                }
            }
            if (!string.IsNullOrEmpty(txtMarka .Text))
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" MarkaAdi like '%{0}%'", txtMarka.Text);
                    dt = dw.ToTable();
                }
            }
            if (!string.IsNullOrEmpty(txtTedarikci .Text))
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" TedarikciAdi like '%{0}%'", txtTedarikci.Text);
                    dt = dw.ToTable();
                }
            }
            if (!string.IsNullOrEmpty(txtDepo.Text))
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" DepoAdi like '%{0}%'", txtDepo.Text);
                    dt = dw.ToTable();
                }
            }
            using (DataView dw = new DataView(dt))
            {
                dw.Sort = "SonKullanmaTarihi ASC";
                dt = dw.ToTable();
            }
            grdStok.DataSource = dt;
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
