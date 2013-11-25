using Businness;
using DataType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace TurStok.Tanimlamalar
{
    public partial class UrunEkleGuncelle : Form
    {
        public UrunEkleGuncelle(UrunTanimla form)
        {
            InitializeComponent();
            f = form as UrunTanimla;
        }
        UrunTanimla f;
        public UrunEkleGuncelle(UrunTanimla form, UrunEntity entity)
        {
            InitializeComponent();
            f = form as UrunTanimla;
            cmbleriDoldur();
            txtUrunAdi.Text = entity.UrunAdi;
            txtAzami.Text = entity.AzamiMiktar.ToString();
            cmbKategoriID.SelectedValue = entity.KategoriID;
            cmbOlcuBirimi.SelectedValue = entity.OlcuBirimID;
            cmbSaklamaKosuluID.SelectedValue = entity.SaklamaKosuluID;
            button1.Tag = entity.UrunID;
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
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    decimal dec;
                    if (cmbKategoriID.SelectedValue == "0" || cmbSaklamaKosuluID.SelectedValue == "0" || string.IsNullOrEmpty(txtUrunAdi.Text) || cmbOlcuBirimi.SelectedValue == "0" || !decimal.TryParse(txtAzami.Text, out dec))
                    {
                        MessageBox.Show("İlgili alanları doldurmanız gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }

                    else
                    {
                        if (button1.Text == "Ekle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["UrunAdi"]).ToString().ToLower().Trim() == txtUrunAdi.Text.ToLower().Trim()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Ürün Vardır. Aynı Ürünü Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
                            {
                                using (UrunBS bs = new UrunBS())
                                {
                                    UrunEntity entity = new UrunEntity { UrunAdi = txtUrunAdi.Text, SaklamaKosuluID = Convert.ToInt64(cmbSaklamaKosuluID.SelectedValue), OlcuBirimID = Convert.ToInt64(cmbOlcuBirimi.SelectedValue), KategoriID = Convert.ToInt64(cmbKategoriID.SelectedValue), AzamiMiktar = Convert.ToDecimal(txtAzami.Text) };
                                    if (bs.Insert(entity))
                                    {
                                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        f.GridDoldur();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                                    }
                                }
                            }
                        }
                        else if (button1.Text == "Güncelle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["UrunAdi"]).ToString().ToLower().Trim() == txtUrunAdi.Text.ToLower().Trim() && x["UrunID"].ToString() != button1.Tag.ToString()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Ürün Vardır. Aynı Ürünü Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
                            {
                                using (UrunBS bs = new UrunBS())
                                {
                                    UrunEntity entity = new UrunEntity { UrunID = Convert.ToInt64(button1.Tag), UrunAdi = txtUrunAdi.Text, SaklamaKosuluID = Convert.ToInt64(cmbSaklamaKosuluID.SelectedValue), OlcuBirimID = Convert.ToInt64(cmbOlcuBirimi.SelectedValue), KategoriID = Convert.ToInt64(cmbKategoriID.SelectedValue), AzamiMiktar = Convert.ToDecimal(txtAzami.Text) };
                                    if (bs.Update(entity))
                                    {
                                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        f.GridDoldur();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Güncelleme Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                                    }
                                }
                            }
                        }
                        f.BringToFront();
                        this.Close();
                    }
                }
                catch (Exception exp)
                {
                    StackTrace st = new StackTrace();
                    StackFrame sf = new StackFrame();
                    new Helper.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
                    return;
                }
            }

        }

        private void UrunEkleGuncelle_Load(object sender, EventArgs e)
        {
            cmbleriDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
