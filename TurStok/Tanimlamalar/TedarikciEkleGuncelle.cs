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
    public partial class TedarikciEkleGuncelle : Form
    {
        TedarikciTanimla f;
        public TedarikciEkleGuncelle(TedarikciTanimla form)
        {
            InitializeComponent();
            f = form as TedarikciTanimla;
        }
        public TedarikciEkleGuncelle(TedarikciTanimla form, TedarikciEntity entity)
        {
            InitializeComponent();
            f = form as TedarikciTanimla;
            txtAdi.Text = entity.TedarikciAdi;
            button1.Tag = entity.TedarikciID;
            txtTelefon.Text = entity.Telefon;
            txtFaks.Text = entity.Faks;
            txtAdres.Text = entity.Adres;
            txtIBAN.Text = entity.IBAN;
            txtEMail.Text = entity.EMail;
            txtHesapNo.Text = entity.BankaHesapNo;
            chkYurtIci.Checked = entity.YurtIcimi;
            button1.Text = "Güncelle";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Tedarikçi Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (button1.Text == "Ekle")
                {
                    if (f.dt.Rows.Cast<DataRow>().Where(x => (x["TedarikciAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
                    {
                        MessageBox.Show("Böyle bir Tedarikçi verdır. Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (TedarikciBS bs = new TedarikciBS())
                        {
                            TedarikciEntity entity = new TedarikciEntity { TedarikciAdi = txtAdi.Text, Telefon = txtTelefon.Text, Faks = txtFaks.Text, Adres = txtAdres.Text, EklenmeTarihi = Convert.ToDateTime(DateTime.Today), BankaHesapNo = txtHesapNo.Text, IBAN = txtIBAN.Text, EMail = txtEMail.Text, YurtIcimi = chkYurtIci.Checked };
                            if (bs.Insert(entity))
                            {
                                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                f.GridDoldur();
                            }
                            else
                            {
                                MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (button1.Text == "Güncelle")
                {
                    if (f.dt.Rows.Cast<DataRow>().Where(x => (x["TedarikciAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()&& x["TedarikciID"].ToString()!=button1.Tag.ToString()).Count() > 0)
                    {
                        MessageBox.Show("Böyle bir Tedarikçi verdır. Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (TedarikciBS bs = new TedarikciBS())
                        {
                            TedarikciEntity entity = new TedarikciEntity { TedarikciID = Convert.ToInt64(button1.Tag), TedarikciAdi = txtAdi.Text, Telefon = txtTelefon.Text, Faks = txtFaks.Text, Adres = txtAdres.Text, EklenmeTarihi = Convert.ToDateTime(DateTime.Today), BankaHesapNo = txtHesapNo.Text, IBAN = txtIBAN.Text, EMail = txtEMail.Text, YurtIcimi = chkYurtIci.Checked };
                            if (bs.Update(entity))
                            {
                                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                f.GridDoldur();
                            }
                            else
                            {
                                MessageBox.Show("Güncelleme Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                f.BringToFront();
                this.Close();
            }
        }
    }
}
