﻿using Businness;
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
    public partial class ParaBirimiEkleGuncelle : Form
    {
        public ParaBirimiEkleGuncelle(ParaBirimiTanimla form)
        {
            InitializeComponent();
            f = form as ParaBirimiTanimla;
        }
        public ParaBirimiEkleGuncelle(ParaBirimiTanimla form, ParaBirimiEntity entity)
        {
            InitializeComponent();
            f = form as ParaBirimiTanimla;
            txtAdi.Text = entity.ParaBirimi;
            button1.Tag = entity.ParaBirimiID;
            button1.Text = "Güncelle";
        }
        ParaBirimiTanimla f;
        private void ParaBirimiEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtAdi.Text))
                    {
                        MessageBox.Show("Para Birimi Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                    else
                    {
                        if (button1.Text == "Ekle")
                        {
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["ParaBirimi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Para Birimi Vardır. Aynı Para Birimini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
                            {
                                using (ParaBirimiBS bs = new ParaBirimiBS())
                                {
                                    ParaBirimiEntity entity = new ParaBirimiEntity { ParaBirimi = txtAdi.Text };
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
                            if (f.dt.Rows.Cast<DataRow>().Where(x => (x["ParaBirimi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim() && x["ParaBirimiID"].ToString() != button1.Tag.ToString()).Count() > 0)
                            {
                                MessageBox.Show("Böyle Bir Para Birimi Vardır. Aynı Para Birimini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                            }
                            else
                            {
                                using (ParaBirimiBS bs = new ParaBirimiBS())
                                {
                                    ParaBirimiEntity entity = new ParaBirimiEntity { ParaBirimiID = Convert.ToInt64(button1.Tag), ParaBirimi = txtAdi.Text };
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
