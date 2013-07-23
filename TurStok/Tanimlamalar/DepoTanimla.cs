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
    public partial class DepoTanimla : Form
    {
        public DepoTanimla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Depo Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["DepoAdi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle Bir Depo Vardır. Aynı Depo İsmini Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (DepoBS bs = new DepoBS())
                {
                    DepoEntity entity = new DepoEntity { DepoAdi = txtAdi.Text};
                    if (bs.Insert(entity))
                    {
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void DepoTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.DepoDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
        }

    }
}