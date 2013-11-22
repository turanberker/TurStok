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

namespace TurStok.Islemler
{
    public partial class FaturasizGiris : Form
    {
        StokGirisi f;
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        public FaturasizGiris(StokGirisi form)
        {
            InitializeComponent();
            f = form as StokGirisi;
        }
        protected void ComboBoxDoldur()
        {
            cmbDepoID.ValueMember = "DepoID";
            cmbDepoID.DisplayMember = "DepoAdi";
            cmbDepoID.DataSource = arac.DepoDoldur();

            cmbUrunID.ValueMember = "UrunID";
            cmbUrunID.DisplayMember = "UrunAdi";
            cmbUrunID.DataSource = arac.UrunDoldur();

            cmbMarkaID.ValueMember = "MarkaID";
            cmbMarkaID.DisplayMember = "MarkaAdi";
            cmbMarkaID.DataSource = arac.MarkaDoldur();

            cmbTedarikciID.ValueMember = "TedarikciID";
            cmbTedarikciID.DisplayMember = "TedarikciAdi";
            cmbTedarikciID.DataSource = arac.TedarikcileriDoldur();
        }

        private void FaturasizGiris_Load(object sender, EventArgs e)
        {
            ComboBoxDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    decimal gelen;
                    DateTime tarih;
                    if (cmbTedarikciID.SelectedValue == "0" || cmbMarkaID.SelectedValue == "0" || cmbDepoID.SelectedValue == "0" || cmbUrunID.SelectedValue == "0" || string.IsNullOrEmpty(txtKalan.Text))
                    {
                        MessageBox.Show("Bütün Alanları Doldurmanız Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (txtBitTar.Enabled == true&& !DateTime.TryParse(txtBitTar.Text, out tarih))
                    {
                        MessageBox.Show("Gelen Miktar Alanına Yanlış Veri Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!decimal.TryParse(txtKalan.Text, out gelen))
                    {
                        MessageBox.Show("Gelen Miktar Alanına Yanlış Veri Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (StokBS bs = new StokBS())
                    {
                        StokEntity entity = new StokEntity()
                        {
                            DepoID = Convert.ToInt64(cmbDepoID.SelectedValue),
                            MarkaID = Convert.ToInt64(cmbMarkaID.SelectedValue),
                            TedarikciID = Convert.ToInt64(cmbTedarikciID.SelectedValue),
                            UrunID = Convert.ToInt64(cmbUrunID.SelectedValue),
                            KalanMiktar = Convert.ToDecimal(txtKalan.Text),
                            GelisTarihi = DateTime.Today
                        };
                        if (txtBitTar.Enabled)
                            entity.SonKullanmaTarihi = Convert.ToDateTime(txtBitTar.Text);
                        if (OlcubirimID.HasValue)
                        {
                            entity.OlcuBirimID = OlcubirimID.Value;
                        }
                        else
                        {
                            MessageBox.Show("Ürün Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (bs.Insert(entity))
                        {
                            MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Sırasında Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    this.Close();
                    scope.Complete();
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
        long? OlcubirimID;
        private void cmbUrunID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunID.SelectedValue != "0")
            {
                using (Businness.UrunBS bs = new Businness.UrunBS())
                {
                    DataTable dt = bs.JoinListe(Convert.ToInt64(cmbUrunID.SelectedValue));
                    if (dt != null || dt.Rows.Count > 0)
                    {
                        OlcubirimID = Convert.ToInt64(dt.Rows[0]["OlcuBirimID"]);
                        txtBitTar.Enabled = dt.Rows[0]["MiadVarmi"].ToString() == "True" ? true : false;
                        lblOlcuBirimi.Text = dt.Rows[0]["OlcuBirimi"].ToString(); 
                    }
                }
            }
            else
                OlcubirimID = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
