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
        public OdemeSekliTanimla()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        protected void GridDoldur()
        {
            dt = arac.OdemeSekliDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
        }
        private void OdemeSekliTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Ödeme Şekli Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["OdemeSekli"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Ödeme Şekli Vardır. Aynı Ödeme Şeklini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (OdemeSekliBS bs = new OdemeSekliBS())
                {
                    OdemeSekliEntity entity = new OdemeSekliEntity { OdemeSekli = txtAdi.Text };
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
