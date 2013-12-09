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

namespace TurStok.Islemler
{
    public partial class İhtiyacListesi : Form
    {
        public İhtiyacListesi(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void İhtiyacListesi_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            GridDoldur();
            CmbDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.IhtiyacListesiDoldur();
            grdIhtiyacListesi.DataSource = dt;
        }
        protected void CmbDoldur()
        {
            cmbUrunID.ValueMember = "UrunID";
            cmbUrunID.DisplayMember = "UrunAdi";
            cmbUrunID.DataSource = arac.UrunDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            if(cmbUrunID.SelectedValue=="0")
            {
                MessageBox.Show("Ürün Seçmeniz gerekiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbUrunID.SelectedValue == null)
            {
                MessageBox.Show("Böyle Bir Ürün Bulunmamaktadır. Önce Ürün Eklemeniz Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (DataView dw = new DataView(dt))
            {
                dw.RowFilter = string.Format(" UrunID = {0}", cmbUrunID.SelectedValue.ToString());
                if (dw.ToTable().Rows.Count != 0)
                {
                    MessageBox.Show("İhtiyaç Listesinde Bu Ürün Bulunmaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            using (IhtiyacListesiBS bs = new IhtiyacListesiBS())
            {
                IhtiyacListesiEntity entity = new IhtiyacListesiEntity { Tarih = DateTime.Today, UrunID = Convert.ToInt64(cmbUrunID.SelectedValue) };
                bs.Insert(entity);
                GridDoldur();
            }
        }

        private void grdIhtiyacListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdIhtiyacListesi.Columns["Sil"].Index)
            {
                using (IhtiyacListesiBS bs = new IhtiyacListesiBS())
                {
                    IhtiyacListesiEntity entity = new IhtiyacListesiEntity { UrunID = Convert.ToInt64(grdIhtiyacListesi.Rows[e.RowIndex].Cells["ID"].Value.ToString()) };
                    if (bs.Delete(entity)) 
                    {
                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GridDoldur();
                    }
                }
            }
        }
        
    }
}
