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
    public partial class MarkaEkleGuncelle : Form
    {
        public MarkaEkleGuncelle(MarkaTanimla form)
        {
            InitializeComponent();
            f = form as MarkaTanimla;
        }
        public MarkaEkleGuncelle(MarkaTanimla form,MarkaEntity entity)
        {
            InitializeComponent();
            txtAdi.Text = entity.MarkaAdi;
            button1.Tag = entity.MarkaID;
            button1.Text = "Güncelle";
            f = form as MarkaTanimla;
        }
        MarkaTanimla f;
        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtAdi.Text))
                    {
                        MessageBox.Show("Marka Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                    else
                    {
                        if (button1.Text == "Ekle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["MarkaAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Marka Vardır. Aynı Kategori Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
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
                                        MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                                    }
                                }
                            }
                        }
                        else if (button1.Text == "Güncelle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["MarkaAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim() && x["MarkaID"].ToString() != button1.Tag.ToString()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Marka Vardır. Aynı Kategori Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
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
                                        MessageBox.Show("Güncelleme Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                                    }
                                }
                            }
                        }
                        
                        f.BringToFront();
                        this.Close();
                        scope.Complete();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
