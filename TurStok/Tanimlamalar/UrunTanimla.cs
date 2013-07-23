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
    public partial class UrunTanimla : Form
    {
        public UrunTanimla()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        protected void GridDoldur()
        {
            dt = arac.TedarikcileriDoldur();
            grdOlcuBirimi.DataSource = dt;
            txtAdi.Text = "";
            txtEMail.Text = "";
            txtFaks.Text = "";
            txtAdres.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "90";
            txtTelefon.Text = "90";
            chkYurtIci.Checked = false;

        }
        private void UrunTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
