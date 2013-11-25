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
    public partial class KategoriEkleGuncelle : Form
    {
        public KategoriEkleGuncelle(KategoriTanimla form)
        {
            InitializeComponent();
            f = form as KategoriTanimla;
        }
        KategoriTanimla f;
        public KategoriEkleGuncelle(KategoriTanimla form, KategoriEntity entity)
        {
            InitializeComponent();
            txtAdi.Text = entity.KategoriAdi;
            checkBox1.Checked = entity.MiadVarmi;
            button1.Tag = entity.KategoriID;
            button1.Text = "Güncelle";
            f = form as KategoriTanimla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtAdi.Text))
                    {
                        MessageBox.Show("Kategori Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (button1.Text == "Ekle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["KategoriAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Kategori Vardır. Aynı Kategori Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                using (KategoriBS bs = new KategoriBS())
                                {
                                    KategoriEntity entity = new KategoriEntity { KategoriAdi = txtAdi.Text, MiadVarmi = checkBox1.Checked };
                                    if (bs.Insert(entity))
                                    {
                                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        f.GridDoldur();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }
                        else if (button1.Text == "Güncelle")
                        {
                            using (KategoriBS bs = new KategoriBS())
                            {
                                if (f.dt.Rows.Cast<DataRow>().Where(x => (x["KategoriAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim() && x["KategoriID"].ToString() != button1.Tag.ToString()).Count() > 0)
                                {
                                    MessageBox.Show("Böyle Bir Kategori Vardır. Aynı Kategori Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                else
                                {
                                    KategoriEntity entity = new KategoriEntity { KategoriID = Convert.ToInt64(button1.Tag), KategoriAdi = txtAdi.Text, MiadVarmi = checkBox1.Checked };
                                    if (bs.Update(entity))
                                    {
                                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        f.GridDoldur();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Güncelleme Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    scope.Complete();
                    f.BringToFront();
                    this.Close();
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
