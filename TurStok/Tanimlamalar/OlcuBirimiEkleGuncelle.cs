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
    public partial class OlcuBirimiEkleGuncelle : Form
    {
        public OlcuBirimiEkleGuncelle(OlcuBirimiTanimla form)
        {
            InitializeComponent();
            f = form as OlcuBirimiTanimla;
        }
        public OlcuBirimiEkleGuncelle(OlcuBirimiTanimla form,OlcuBirimiEntity entity)
        {
            InitializeComponent();
            f = form as OlcuBirimiTanimla;
            txtAdi.Text = entity.OlcuBirimi;
            button1.Tag = entity.OlcuBirimiID;
            button1.Text = "Güncelle";
        }
        OlcuBirimiTanimla f;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Ölçü Birimi Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (f.dt.Rows.Cast<DataRow>().Where(x => (x["OlcuBirimi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Ölçü Birimi Vardır. Aynı Ölçü Birimini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    using (OlcuBirimiBS bs = new OlcuBirimiBS())
                    {
                        OlcuBirimiEntity entity = new OlcuBirimiEntity { OlcuBirimi = txtAdi.Text };
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
                    using (OlcuBirimiBS bs = new OlcuBirimiBS())
                    {
                        OlcuBirimiEntity entity = new OlcuBirimiEntity { OlcuBirimiID = Convert.ToInt64(button1.Tag), OlcuBirimi = txtAdi.Text };
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

        private void txtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
