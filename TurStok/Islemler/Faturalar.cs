using Businness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TurStok.Islemler;

namespace TurStok
{
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }    
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void Faturalar_Load(object sender, EventArgs e)
        {
            GridDoldur();
            ComboBoxDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.FaturaDoldur();
            grdFatura.DataSource = dt;
        }
        protected void ComboBoxDoldur()
        {

            cmbTedarikciID.ValueMember = "TedarikciID";
            cmbTedarikciID.DisplayMember = "TedarikciAdi";
            DataTable Ted = arac.TedarikcileriDoldur();
            Ted.Rows.Add(0, 0, "Hepsi");
            cmbTedarikciID.DataSource = Ted;
            cmbTedarikciID.SelectedIndex = 0;
            cmbDurumu.SelectedIndex = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FaturaEkle f = new FaturaEkle();
            f.Show();
        }
        private void grdFatura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = false;
            grdFaturaDetay.DataSource = null;
            if (grdFatura.Columns[e.ColumnIndex].Name == "OdemeYap")
            {
                if (grdFatura.Rows[e.RowIndex].Cells["OdemeYapildimi"].Value.ToString() == "False")
                {
                    using (FaturaBS bs = new FaturaBS())
                    {
                        if (bs.OdemeYap(Convert.ToInt64(grdFatura.Rows[e.RowIndex].Cells["FaturaID"].Value)))
                        {
                            GridDoldur();
                            MessageBox.Show("Ödeme Gerçekleşmiştir", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("İşlemi Sırasında Hata Olmuştur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ödeme Daha Önce Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                groupBox1.Visible = true;
                string faturaId = grdFatura.Rows[e.RowIndex].Cells["FaturaID"].Value.ToString();
                grdFaturaDetay.DataSource = arac.FaturaDetayDoldur(Convert.ToInt64(faturaId));
            }
        }
        void FaturaFiltrele()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            DataTable FaturaFiltre = null;
            if (cmbTedarikciID.Text != "Hepsi")
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" TedarikciID = '{0}'", Convert.ToInt64(cmbTedarikciID.SelectedValue));
                    FaturaFiltre = dw.ToTable();
                }
            }
            else
            {
                FaturaFiltre = dt;
            }
            if (cmbDurumu.Text != "Hepsi")
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" OdemeYapildimi = '{0}'", cmbDurumu.Text=="Ödemesi Yapılmişlar"?true:false );
                    FaturaFiltre = dw.ToTable();
                }
            }
            DateTime tarih;
            if (!string.IsNullOrEmpty(txtBasTar.Text) && !DateTime.TryParse(txtBasTar.Text, out tarih)&&txtBasTar.Text.Trim().Length==10)
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" FaturaTarihi > '{0}'",tarih);
                    FaturaFiltre = dw.ToTable();
                }
            }
            int sa = txtBitTar.Text.Trim().Length;
            if (!string.IsNullOrEmpty(txtBitTar.Text) && !DateTime.TryParse(txtBitTar.Text, out tarih) && txtBitTar.Text.Trim().Length == 10)
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" FaturaTarihi < '{0}'", tarih);
                    FaturaFiltre = dw.ToTable();
                }
            }
            grdFatura.DataSource = FaturaFiltre;
        }

        private void cmbTedarikciID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void cmbDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void txtBasTar_TextChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void txtBitTar_TextChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }
    }
}
