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
    public partial class TedarikciTanimla : Form
    {
        public TedarikciTanimla()
        {
            InitializeComponent();
        }
        public TedarikciTanimla(Main form)
        {
            InitializeComponent();
            anaform = form as Main ;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();


        private void TedarikciTanimla_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.TedarikcileriDoldur();
            grdOlcuBirimi.DataSource = dt;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("TedarikciEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new TedarikciEkleGuncelle(this as TedarikciTanimla);
            f.MdiParent = anaform;
            f.Show();
        }

       
        private void grdOlcuBirimi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow secilen = dt.Rows.Cast<DataRow>().Where(x => x["TedarikciID"].ToString() == grdOlcuBirimi.Rows[e.RowIndex].Cells["TedarikciID"].Value.ToString()).FirstOrDefault();
            TedarikciEntity entity = new TedarikciEntity { TedarikciID = Convert.ToInt64(secilen["TedarikciID"]), TedarikciAdi = secilen["TedarikciAdi"].ToString(), Adres = secilen["Adres"].ToString(), BankaHesapNo = secilen["BankaHesapNo"].ToString(), EklenmeTarihi=Convert.ToDateTime(secilen["EklenmeTarihi"]), EMail=secilen["EMail"].ToString(), Faks=secilen["Faks"].ToString(), IBAN=secilen["IBAN"].ToString(), Telefon=secilen["Telefon"].ToString(), YurtIcimi=secilen["YurtIcimi"].ToString()=="True"?true:false };
            Form f = anaform.Varmi("TedarikciEkleGuncelle");
            if (f != null)
            {
                f.Close();
            }
            f = new TedarikciEkleGuncelle(this as TedarikciTanimla,entity);
            f.MdiParent = anaform;
            f.Show();
        }

        
    }
}
