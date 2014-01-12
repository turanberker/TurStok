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
    public partial class StokDetay : Form
    {
        public StokDetay(Main form, DataRow secilen)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            InitializeComponent();
            lblUrunAdi.Text = secilen["UrunAdi"].ToString();
            lblKalanMiktar.Text = txtCekilen.Text = secilen["KalanMiktar"].ToString();
            lblBirimi.Text = secilen["OlcuBirimi"].ToString();
            lblDeposu.Text = secilen["DepoAdi"].ToString();
            lblGelisTarihi.Text = Convert.ToDateTime(secilen["GelisTarihi"]).ToShortDateString();
            lblKategorisi.Text = secilen["KategoriAdi"].ToString();
            lblSonKullanmaTarihi.Text = !string.IsNullOrEmpty(secilen["SonKullanmaTarihi"].ToString()) ? Convert.ToDateTime(secilen["SonKullanmaTarihi"]).ToString("dd.MM.yyyy") : "-";
            lblDeposu.Text = secilen["DepoAdi"].ToString();
            lblTedarikcisi.Text = secilen["TedarikciAdi"].ToString();
            button1.Tag = secilen["StokID"];
            if (string.IsNullOrEmpty(secilen["FaturaDetayID"].ToString()))
                btnFatura.Enabled = false;
            else
                btnFatura.Tag = secilen["FaturaDetayID"];
            Anaform = form;
            ComboBoxDoldur();
            cmbDepoID.SelectedValue = Convert.ToInt64(secilen["DepoID"]);
        }

        private Main Anaform;
        private void button1_Click(object sender, EventArgs e)
        {
            decimal cekilen;
            if (string.IsNullOrEmpty(txtCekilen.Text))
            {
                MessageBox.Show("Depodan Çekilen Miktar Alanını Doldurmanız Gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!decimal.TryParse(txtCekilen.Text, out cekilen))
            {
                MessageBox.Show("Depodan Çekilen Miktar Alanına Sadece Sayı Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDecimal(txtCekilen.Text) > Convert.ToDecimal(lblKalanMiktar.Text))
            {
                MessageBox.Show("Depoda Kalan Miktardan Fazla Miktar Çekemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblKalanMiktar.Text = txtCekilen.Text = (Convert.ToDecimal(lblKalanMiktar.Text) - Convert.ToDecimal(txtCekilen.Text)).ToString();
                using (StokBS bs = new StokBS())
                {
                    bs.DepodanCik(Convert.ToInt64(button1.Tag), Convert.ToDecimal(lblKalanMiktar.Text));
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Anaform.GridleriDoldur();
                }
            }
        }
        protected void ComboBoxDoldur()
        {
            cmbDepoID.ValueMember = "DepoID";
            cmbDepoID.DisplayMember = "DepoAdi";
            cmbDepoID.DataSource = new Helper.GridDoldurucular().DepoDoldur();
        }
        private void StokDetay_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbDepoID.SelectedValue == null)
            {
                MessageBox.Show("Böyle Bir Depo Bulunmamaktadır. Önce Depo Eklemeniz Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (StokBS bs = new StokBS())
                {
                    bs.DepoDegistir(Convert.ToInt64(button1.Tag), Convert.ToInt64(cmbDepoID.SelectedValue));
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Anaform.GridleriDoldur();
                }
            }
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            Form f = Anaform.Varmi("FaturaDetay");
            if (f == null)
            {
                f = new FaturaDetay(Convert.ToInt64(btnFatura.Tag));
                f.MdiParent = Anaform;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal cekilen;
            if (string.IsNullOrEmpty(txtYeniMiktar.Text))
            {
                MessageBox.Show("Yeni Miktar Alanını Doldurmanız Gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!decimal.TryParse(txtYeniMiktar.Text, out cekilen))
            {
                MessageBox.Show("Yeni Miktar Alanına Sadece Sayı Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblKalanMiktar.Text = txtYeniMiktar.Text;
                using (StokBS bs = new StokBS())
                {
                    bs.DepodanCik(Convert.ToInt64(button1.Tag), Convert.ToDecimal(lblKalanMiktar.Text));
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Anaform.GridleriDoldur();
                }
            }
        }
    }
}
