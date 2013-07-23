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
    public partial class TedarikciTanimla : Form
    {
        public TedarikciTanimla()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TedarikciTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.TedarikcileriDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
            txtEMail.Text = "";
            txtFaks.Text = "";
            txtAdres.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "90";
            txtTelefon.Text = "90";
            chkYurtIci.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Ölçü Birimi Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["TedarikciAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle bir ölçü birimi verdır. Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (TedarikciBS bs = new TedarikciBS())
                {
                    TedarikciEntity entity = new TedarikciEntity { TedarikciAdi = txtAdi.Text, Telefon = txtTelefon.Text, Faks = txtFaks.Text, Adres = txtAdres.Text, EklenmeTarihi = Convert.ToDateTime(DateTime.Today.ToString("dd.MM.yyyy")), BankaHesapNo = txtHesapNo.Text, IBAN = txtIBAN.Text, EMail = txtEMail.Text, YurtIcimi = chkYurtIci.Checked };
                    if (bs.Insert(entity))
                    {
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdOlcuBirimi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkYurtIci_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHesapNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtIBAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFaks_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grdOlcuBirimi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
