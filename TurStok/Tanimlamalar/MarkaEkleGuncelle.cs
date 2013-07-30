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
    public partial class MarkaEkleGuncelle : Form
    {
        public MarkaEkleGuncelle()
        {
            InitializeComponent();
        }
        public MarkaEkleGuncelle(MarkaEntity entity)
        {
            InitializeComponent();
            txtAdi.Text = entity.MarkaAdi;
            button1.Tag = entity.MarkaID;
            button1.Text = "Güncelle";
        }
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();

        private void button1_Click(object sender, EventArgs e)
        {
            MarkaTanimla f = null;
            foreach (Form item in this.ParentForm.MdiChildren)
            {
                if (item.Text == "Marka Tanımla")
                {
                    f = item as MarkaTanimla;
                    break;
                }
            }
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Marka Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (f.dt.Rows.Cast<DataRow>().Where(x => (x["MarkaAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Marka Vardır. Aynı Kategori Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    using (MarkaBS bs = new MarkaBS())
                    {
                        MarkaEntity entity = new MarkaEntity { MarkaAdi = txtAdi.Text };
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
                    using (MarkaBS bs = new MarkaBS())
                    {
                        MarkaEntity entity = new MarkaEntity { MarkaID = Convert.ToInt64(button1.Tag), MarkaAdi = txtAdi.Text };
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
