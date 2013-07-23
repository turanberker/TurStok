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
    public partial class ParaBirimiTanimla : Form
    {
        public ParaBirimiTanimla()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void ParaBirimiTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.ParaBirimiDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Para Birimi Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["ParaBirimi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Para Birimi Vardır. Aynı Para Birimini İsmini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (ParaBirimiBS bs = new ParaBirimiBS())
                {
                    ParaBirimiEntity entity = new ParaBirimiEntity { ParaBirimi = txtAdi.Text };
                    if (bs.Insert(entity))
                    {
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
