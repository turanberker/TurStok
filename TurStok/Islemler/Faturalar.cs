﻿using Businness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Transactions;
using System.Windows.Forms;
using TurStok.Islemler;

namespace TurStok
{
    public partial class Faturalar : Form
    {
        public Faturalar(Main form)
        {
            InitializeComponent();
            anaform = form;
        }
        private Main anaform;
        public DataTable dt = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        bool Editteble;
        private void Faturalar_Load(object sender, EventArgs e)
        {
            GridDoldur();
            ComboBoxDoldur();
        }
        public void GridDoldur()
        {
            dt = arac.FaturaDoldur();
            grdFatura.DataSource = dt;
        }
        protected void ComboBoxDoldur()
        {
            cmbTedarikciID.ValueMember = "TedarikciID";
            cmbTedarikciID.DisplayMember = "TedarikciAdi";
            DataTable Ted = arac.TedarikcileriDoldur();
            Ted.Rows.Add(0, 0, "Hepsi");
            cmbTedarikciID.DataSource = Ted;
            cmbTedarikciID.SelectedIndex = 0;
            cmbDurumu.SelectedIndex = 0;

            cmbOdeme.ValueMember = "OdemeSekilID";
            cmbOdeme.DisplayMember = "OdemeSekli";
            DataTable OdSek = arac.OdemeSekliDoldur();
            OdSek.Rows.Add(0, 0, "Hepsi");
            cmbOdeme.DataSource = OdSek;
            cmbOdeme.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f = anaform.Varmi("FaturaEkle");
            if (f != null)
            {
                f.Close();
            }
            f = new FaturaEkle(this as Faturalar);
            f.MdiParent = anaform;
            f.Show();

        }
        private void grdFatura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    groupBox1.Visible = false;
                    if (grdFatura.Columns[e.ColumnIndex].Name == "OdemeYap")
                    {
                        if (grdFatura.Rows[e.RowIndex].Cells["OdemeYapildimi"].Value.ToString() == "False")
                        {
                            using (FaturaBS bs = new FaturaBS())
                            {
                                if (bs.OdemeYap(Convert.ToInt64(grdFatura.Rows[e.RowIndex].Cells["FaturaID"].Value)))
                                {
                                    GridDoldur();
                                    MessageBox.Show("Ödeme Gerçekleşmiştir", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    scope.Complete();
                                }
                                else
                                {
                                    MessageBox.Show("İşlemi Sırasında Hata Olmuştur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ödeme Daha Önce Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (grdFatura.Columns[e.ColumnIndex].Name == "FSil")
                    {
                        if (grdFatura.Rows[e.RowIndex].Cells["OdemeYapildimi"].Value.ToString() == "True")
                        {
                            MessageBox.Show("Ödemesi Yapılmış Olduğu İçin Faturayı Silemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            using (FaturaBS bs = new FaturaBS())
                            {
                                if (bs.Sil(Convert.ToInt64(grdFatura.Rows[e.RowIndex].Cells["FaturaID"].Value)))
                                {
                                    GridDoldur();
                                    MessageBox.Show("Fatura Silinmiştir..", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    scope.Complete();
                                }
                                else
                                {
                                    MessageBox.Show("Taslimatı Gerçekleşmiş Ürün Olduğu İçin Fatura Silinememiştir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                    }
                    else
                    {
                        Editteble = grdFatura.Rows[e.RowIndex].Cells["OdemeYapildimi"].Value.ToString() == "True" ? false : true;
                        groupBox1.Visible = true;
                        string faturaId = grdFatura.Rows[e.RowIndex].Cells["FaturaID"].Value.ToString();
                        grdFaturaDetay.DataSource = arac.FaturaDetayDoldur(Convert.ToInt64(faturaId));
                        grdFaturaDetay.Columns["FaturaDetayID"].Visible = false;
                        grdFaturaDetay.Columns[2].Visible = false;
                        grdFaturaDetay.Columns["UrunId"].Visible = false;
                        grdFaturaDetay.Columns["MarkaID"].Visible = false;
                        grdFaturaDetay.Columns["Sil"].Visible = true;
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
        void FaturaFiltrele()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            DataTable FaturaFiltre = null;
            if (cmbTedarikciID.Text != "Hepsi")
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" TedarikciID = '{0}'", Convert.ToInt64(cmbTedarikciID.SelectedValue));
                    FaturaFiltre = dw.ToTable();
                }
            }
            else
            {
                FaturaFiltre = dt;
            }
            if (cmbDurumu.Text != "Hepsi")
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" OdemeYapildimi = '{0}'", cmbDurumu.Text == "Ödemesi Yapılmişlar" ? true : false);
                    FaturaFiltre = dw.ToTable();
                }
            }
            DateTime tarih;
            if (!string.IsNullOrEmpty(txtBasTar.Text) && !DateTime.TryParse(txtBasTar.Text, out tarih) && txtBasTar.Text.Trim().Length == 10)
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" FaturaTarihi > '{0}'", tarih);
                    FaturaFiltre = dw.ToTable();
                }
            }
            int sa = txtBitTar.Text.Trim().Length;
            if (!string.IsNullOrEmpty(txtBitTar.Text) && !DateTime.TryParse(txtBitTar.Text, out tarih) && txtBitTar.Text.Trim().Length == 10)
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" FaturaTarihi < '{0}'", tarih);
                    FaturaFiltre = dw.ToTable();
                }
            }
            if (cmbOdeme.Text != "Hepsi")
            {
                using (DataView dw = new DataView(dt))
                {
                    dw.RowFilter = string.Format(" OdemeSekliID = '{0}'", Convert.ToInt64(cmbOdeme.SelectedValue));
                    FaturaFiltre = dw.ToTable();
                }
            }
            grdFatura.DataSource = FaturaFiltre;
        }

        private void cmbTedarikciID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void cmbDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void txtBasTar_TextChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void txtBitTar_TextChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void cmbOdeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            FaturaFiltrele();
        }

        private void grdFaturaDetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (e.ColumnIndex == grdFaturaDetay.Columns["Sil"].Index)
                    {
                        if (Convert.ToBoolean(grdFaturaDetay.Rows[e.RowIndex].Cells["TeslimAlindimi"].Value))
                        {
                            MessageBox.Show("Ürün Teslim Alındığından bu Kalem Silinemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            using (FaturaDetayBS bs = new FaturaDetayBS())
                            {
                                if (Editteble)
                                {
                                    string asd = grdFaturaDetay.Rows[e.RowIndex].Cells["FaturaDetayID"].Value.ToString();
                                    if (bs.Sil(Convert.ToInt64(asd)))
                                    {
                                        MessageBox.Show("İşleminiz Başarı İle Gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        grdFaturaDetay.DataSource = null;
                                        string faturaId = grdFatura.Rows[e.RowIndex].Cells["DFaturaID"].Value.ToString();
                                        grdFaturaDetay.DataSource = arac.FaturaDetayDoldur(Convert.ToInt64(faturaId));
                                        grdFaturaDetay.Columns["FaturaDetayID"].Visible = false;
                                        grdFaturaDetay.Columns[2].Visible = false;
                                        grdFaturaDetay.Columns["UrunId"].Visible = false;
                                        grdFaturaDetay.Columns["MarkaID"].Visible = false;
                                        grdFaturaDetay.Columns["Sil"].Visible = true;
                                        GridDoldur();
                                    }
                                    else
                                    {
                                        MessageBox.Show("İşlemi Sırasında Hata Olmuştur. Lütfen Tekrar Deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Faturanın Ödemesi Yapıldığından Silme İşlemi Yapamazsınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
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
}
