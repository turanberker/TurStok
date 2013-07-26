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
        public UrunTanimla()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        protected void GridDoldur()
        {
            dt = arac.UrunDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtUrunAdi.Text = "";
            txtAzami.Text = "";
            cmbSaklamaKosuluID.SelectedIndex = 0;
            cmbKategoriID.SelectedIndex = 0;
            cmbOlcuBirimi.SelectedIndex = 0;


        }

        protected void cmbleriDoldur()
        {
            DataTable Kategoriler = arac.KategoriDoldur();
            DataTable SaklamaKosulu = arac.SaklamaKosuluDoldur();
            DataTable OlcuBirimleri = arac.OlcuBirimiDoldur();
            cmbKategoriID.ValueMember = "KategoriID";
            cmbKategoriID.DisplayMember = "KategoriAdi";
            cmbSaklamaKosuluID.ValueMember = "SaklamaKosuluID";
            cmbSaklamaKosuluID.DisplayMember = "SaklamaKosulu";
            cmbKategoriID.DataSource = Kategoriler;
            cmbSaklamaKosuluID.DataSource = SaklamaKosulu;
            cmbOlcuBirimi.ValueMember = "OlcuBirimiID";
            cmbOlcuBirimi.DisplayMember = "OlcuBirimi";
            cmbOlcuBirimi.DataSource = OlcuBirimleri;

        }
        private void UrunTanimla_Load(object sender, EventArgs e)
        {
            cmbleriDoldur();
            GridDoldur();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal dec;
            if (cmbKategoriID.SelectedValue == "0" || cmbSaklamaKosuluID.SelectedValue == "0" || string.IsNullOrEmpty(txtUrunAdi.Text)|| cmbOlcuBirimi.SelectedValue=="0" || !decimal.TryParse(txtAzami.Text, out dec))
            {
                MessageBox.Show("İlgili alanları doldurmanız gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["UrunAdi"]).ToString().ToLower().Trim() == txtUrunAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Ürün Vardır. Aynı Ürünü Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UrunBS bs = new UrunBS())
                {
                    UrunEntity entity = new UrunEntity { UrunAdi = txtUrunAdi.Text, KategoriID = Convert.ToInt64(cmbKategoriID.SelectedValue), SaklamaKosuluID = Convert.ToInt64(cmbSaklamaKosuluID.SelectedValue), AzamiMiktar = dec, OlcuBirimID=Convert.ToInt64(cmbOlcuBirimi.SelectedValue) };
                    if (bs.Insert(entity))
                    {
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbSaklamaKosuluID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
