using Businness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurStok.Islemler
{
    public partial class StokGirisi : Form
    {
        public StokGirisi()
        {
            InitializeComponent();
        }

        private void grdFaturaDetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            grdBeklenen.DataSource = null;
            if (grdBeklenen.Columns[e.ColumnIndex].Name == "Gir")
            {
                if (grdBeklenen.Rows[e.RowIndex].Cells["TeslimAlindimi"].Value.ToString() == "False")
                {
                    using (FaturaBS bs = new FaturaBS())
                    {
                        //if (bs.OdemeYap(Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["FaturaID"].Value)))
                            if(true)
                        {
                            GridDoldur();
                            MessageBox.Show("Malzeme Stoğa Eklenmiştir.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("İşlem Sırasında Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Malzeme Daha Önce Teslim Alındığından Tekrar Alınamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void StokGirisi_Load(object sender, EventArgs e)
        {
            
            GridDoldur();
            DataGridViewComboBoxColumn Depolar = new DataGridViewComboBoxColumn();
            Depolar.DisplayMember="DepoAdi";
            Depolar.ValueMember="DepoID";
            Depolar.HeaderText="Depo Seçin";
            Depolar.Name = "Depo";
            Depolar.DataPropertyName = "DepoID";
            Depolar.DataSource = arac.DepoDoldur();
            Depolar.Frozen = false;
            grdBeklenen.Columns.Add(Depolar);
 
        }
        protected void GridDoldur()
        {
            dt = arac.BeklenenMalzemeleriDoldur();
            grdBeklenen.DataSource = dt;
            
        }
    }
}
