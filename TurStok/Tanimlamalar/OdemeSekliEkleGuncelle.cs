﻿using Businness;
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
    public partial class OdemeSekliEkleGuncelle : Form
    {
        public OdemeSekliEkleGuncelle(OdemeSekliTanimla form)
        {
            InitializeComponent();
            f = form as OdemeSekliTanimla;
        }
        public OdemeSekliEkleGuncelle(OdemeSekliTanimla form,OdemeSekliEntity entity)
        {
            InitializeComponent();
            f = form as OdemeSekliTanimla;
            txtAdi.Text = entity.OdemeSekli;
            button1.Tag = entity.OdemeSekilID;
            button1.Text = "Güncelle";
        }
        OdemeSekliTanimla f;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Ödeme Şekli Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (f.dt.Rows.Cast<DataRow>().Where(x => (x["OdemeSekli"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Ödeme Şekli Vardır. Aynı İsmi Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (button1.Text == "Ekle")
                {
                    using (OdemeSekliBS bs = new OdemeSekliBS())
                    {
                        OdemeSekliEntity entity = new OdemeSekliEntity { OdemeSekli = txtAdi.Text };
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
                    using (OdemeSekliBS bs = new OdemeSekliBS())
                    {
                        OdemeSekliEntity entity = new OdemeSekliEntity { OdemeSekilID = Convert.ToInt64(button1.Tag), OdemeSekli = txtAdi.Text };
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