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
    public partial class SaklamaKosuluEkleGuncelle : Form
    {
        public SaklamaKosuluEkleGuncelle(SaklamaKosuluTanimla form)
        {
            InitializeComponent();
            f = form as SaklamaKosuluTanimla;
        }
        public SaklamaKosuluEkleGuncelle(SaklamaKosuluTanimla form, SaklamaKosuluEntity entity)
        {
            InitializeComponent();
            f = form as SaklamaKosuluTanimla;
            txtAdi.Text = entity.SaklamaKosuluAdi;
            button1.Tag = entity.SaklamaKosuluID;
            button1.Text = "Güncelle";
        }
        SaklamaKosuluTanimla f;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Saklama Koşulu Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (f.dt.Rows.Cast<DataRow>().Where(x => (x["SaklamaKosulu"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Saklama Koşulu Mevcuttur. Aynı Kuşulu Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    using (SaklamaKosuluBS bs = new SaklamaKosuluBS())
                    {
                        SaklamaKosuluEntity entity = new SaklamaKosuluEntity { SaklamaKosuluAdi = txtAdi.Text };
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
                else if (button1.Text == "Güncelle")
                {
                    using (SaklamaKosuluBS bs = new SaklamaKosuluBS())
                    {
                        SaklamaKosuluEntity entity = new SaklamaKosuluEntity { SaklamaKosuluID = Convert.ToInt64(button1.Tag), SaklamaKosuluAdi = txtAdi.Text };
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
                f.BringToFront();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
