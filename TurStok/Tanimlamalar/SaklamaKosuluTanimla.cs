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
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Saklama Koşulu Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["SaklamaKosulu"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Koşul Vardır. Aynı Koşulu Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SaklamaKosuluBS bs = new SaklamaKosuluBS())
                {
                    SaklamaKosuluEntity entity = new SaklamaKosuluEntity { SaklamaKosuluAdi = txtAdi.Text };
                    if (bs.Insert(entity))
                    {
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaklamaKosuluTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.SaklamaKosuluDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
        }
    }
}
