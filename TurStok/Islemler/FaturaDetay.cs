using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurStok.Islemler
{
    public partial class FaturaDetay : Form
    {
        public FaturaDetay(long FaturaDetayID)
        {
            InitializeComponent();
            Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
            //DataTable detay=arac.FaturaDetayDoldurbyFaturaDetayID(FaturaDetayID);
            DataRow Fatura = arac.FaturDoldurbyFaturaDetayID(FaturaDetayID).Rows[0];
            grdFaturaDetay.DataSource = arac.FaturaDetayDoldurbyFaturaDetayID(FaturaDetayID);
            lblFaturaNo.Text = Fatura["FaturaNo"].ToString();
            lblFaturaTarihi.Text = Convert.ToDateTime(Fatura["FaturaTarihi"]).ToString("dd.MM.yyyy");
            lblAciklama.Text = Fatura["Aciklama"].ToString();
            lblKur.Text = string.IsNullOrEmpty(Fatura["Kur"].ToString()) ? "-" : Fatura["Kur"].ToString();
            chkOdeme.Checked = Fatura["OdemeYapildimi"].ToString() == "True" ? true : false;
            lblFaturaTutari.Text = string.IsNullOrEmpty(Fatura["FaturaTutari"].ToString()) ? "-" : Fatura["FaturaTutari"].ToString();
            lblParaBirimi.Text = Fatura["ParaBirimi"].ToString();
            lblOdemeSekli.Text = Fatura["OdemeSekli"].ToString();
            lblTedarikci.Text = Fatura["TedarikciAdi"].ToString();
        }
    }
}
