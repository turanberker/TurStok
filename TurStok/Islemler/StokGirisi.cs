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
using System.Transactions;
using System.Diagnostics;

namespace TurStok.Islemler
{
    public partial class StokGirisi : Form
    {
        public StokGirisi(Main f)
        {
            InitializeComponent();
            anaform = f;
        }
        private Main anaform;
        private void grdFaturaDetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                if (grdBeklenen.Columns[e.ColumnIndex].Name == "Gir")
                {
                    try
                    {

                        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                        DateTime tarih;
                        decimal gelen;
                        txtSonTarih.Text = txtSonTarih.Text.Replace(',', '.');
                        if (string.IsNullOrEmpty(cmbDepoID.Text))
                        {
                            MessageBox.Show("Malzemenin Gireceği Depoyu Seçmediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (cmbDepoID.SelectedValue == null)
                        {
                            MessageBox.Show("Böyle Bir Depo Bulunmamaktadır. Önce Depo Eklemeniz Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (Convert.ToBoolean(grdBeklenen.Rows[e.RowIndex].Cells["MiadVarmi"].Value) && !DateTime.TryParse(txtSonTarih.Text, out tarih))
                        {
                            MessageBox.Show("Seçtiğiniz Malzemenin Miadı Olduğundan Geçrli Bir Miad Girmelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!string.IsNullOrEmpty(txtGelenMiktar.Text) && !decimal.TryParse(txtGelenMiktar.Text, out gelen))
                        {
                            MessageBox.Show("Gelen Miktar Alanına Yanlış Veri Girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (FaturaDetayBS bs = new FaturaDetayBS())
                            {
                                decimal Gelen;
                                if (string.IsNullOrEmpty(txtGelenMiktar.Text))

                                    Gelen = Convert.ToDecimal(grdBeklenen.Rows[e.RowIndex].Cells["SiparisVerilenMiktar"].Value);
                                else
                                    Gelen = Convert.ToDecimal(txtGelenMiktar.Text);

                                if (bs.TeslimAl(Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["FaturaDetayID"].Value), Gelen))
                                {
                                    using (StokBS sbs = new StokBS())
                                    {
                                        StokEntity entity = new StokEntity();
                                        entity.OlcuBirimID = Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["OlcuBirimiID"].Value);
                                        entity.MarkaID = Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["MarkaID"].Value);
                                        entity.UrunID = Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["UrunID"].Value);
                                        entity.TedarikciID = Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["TedarikciID"].Value);
                                        entity.FaturaDetayID = Convert.ToInt64(grdBeklenen.Rows[e.RowIndex].Cells["FaturaDetayID"].Value);
                                        entity.DepoID = Convert.ToInt64(cmbDepoID.SelectedValue);
                                        entity.KalanMiktar = Gelen;
                                        //MiadVarmi
                                        if (Convert.ToBoolean(grdBeklenen.Rows[e.RowIndex].Cells["MiadVarmi"].Value))
                                        {
                                            DateTime qtarih;
                                            if (!DateTime.TryParse(txtSonTarih.Text, out tarih))
                                            {
                                                MessageBox.Show("Girişi Yapılan Malzeme için bir Geçerli Bir Miat Girmeniz Gerekmektedir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                return;
                                            }
                                            else
                                            {
                                                entity.SonKullanmaTarihi = Convert.ToDateTime(txtSonTarih.Text);
                                            }
                                        }
                                        entity.GelisTarihi = DateTime.Today;
                                        GridDoldur();
                                        if (sbs.Insert(entity))
                                        {
                                            MessageBox.Show("Malzeme Stoğa Eklenmiştir.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            anaform.GridleriDoldur();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Malzeme Depoya Girerken Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Teslim Alırken Bir Hata Oluştu. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
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
            

        }


        DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        private void StokGirisi_Load(object sender, EventArgs e)
        {
            GridDoldur();
            ComboBoxDoldur();
        }
        protected void ComboBoxDoldur()
        {
            cmbDepoID.ValueMember = "DepoID";
            cmbDepoID.DisplayMember = "DepoAdi";
            cmbDepoID.DataSource = arac.DepoDoldur();
        }
        protected void GridDoldur()
        {
            dt = arac.BeklenenMalzemeleriDoldur();
            grdBeklenen.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("FaturasizGiris");
            if (f != null)
            {
                f.Close();
            }
            f = new FaturasizGiris(this as StokGirisi);
            f.MdiParent = anaform;
            f.Show();
        }
    }
}
