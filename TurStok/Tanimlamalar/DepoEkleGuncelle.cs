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
    public partial class DepoEkleGuncelle : Form
    {
        public DepoEkleGuncelle()
        {
            InitializeComponent();
        }
        public DepoEkleGuncelle(DepoEntity entity)
        {
            InitializeComponent();
            txtAdi.Text = entity.DepoAdi;
            button1.Tag = entity.DepoID;
            button1.Text = "Güncelle";
        }
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void DepoEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepoTanimla f = null;
            foreach (Form item in this.ParentForm.MdiChildren)
            {
                if (item.Text == "Depo Tanımla")
                {
                    f = item as DepoTanimla;
                    break;
                }
            }
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Depo Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (f.dt.Rows.Cast<DataRow>().Where(x => (x["DepoAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Depo Mevcuttur. Aynı Depo İsmini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    using (DepoBS bs = new DepoBS())
                    {
                        DepoEntity entity = new DepoEntity { DepoAdi = txtAdi.Text };
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
                    using (DepoBS bs = new DepoBS())
                    {
                        DepoEntity entity = new DepoEntity { DepoID = Convert.ToInt64(button1.Tag), DepoAdi = txtAdi.Text };
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
