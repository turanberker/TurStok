﻿using Businness;
using DataType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurStok
{
    public partial class OlcuBirimiTanimla : Form
    {
        public OlcuBirimiTanimla()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void OlcuBirimiTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.OlcuBirimiDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAdi.Text))
            {
                MessageBox.Show("Ölçü Birimi Adı Kısmını doldurmanız gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Cast<DataRow>().Where(x => (x["OlcuBirimi"]).ToString().ToLower().Trim() == txtAdi.Text.ToLower().Trim()).Count() > 0)
            {
                MessageBox.Show("Böyle bir ölçü birimi verdır. Tekrar Ekleyemezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (OlcuBirimiBS bs = new OlcuBirimiBS())
                {
                    OlcuBirimiEntity entity = new OlcuBirimiEntity { OlcuBirimi = txtAdi.Text };
                    if (bs.Insert(entity))
                    {                        
                        GridDoldur();
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
