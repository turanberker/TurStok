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
    public partial class FaturaEkle : Form
    {
        public FaturaEkle(Faturalar form)
        {
            InitializeComponent();
            f = form as Faturalar;
        }
        Faturalar f;
        DataTable detaylar = new DataTable();
        Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
        protected void cmbleriDoldur()
        {
            DataTable Tedarikciler = arac.TedarikcileriDoldur();
            DataTable ParaBirimi = arac.ParaBirimiDoldur();
            DataTable OdemeSekli = arac.OdemeSekliDoldur();
            cmbTedarikciID.ValueMember = "TedarikciID";
            cmbTedarikciID.DisplayMember = "TedarikciAdi";
            cmbOdemeSekliID.ValueMember = "OdemeSekilID";
            cmbOdemeSekliID.DisplayMember = "OdemeSekli";
            cmbParaBirimiID.DataSource = ParaBirimi;
            cmbTedarikciID.DataSource = Tedarikciler;
            cmbParaBirimiID.ValueMember = "ParaBirimiID";
            cmbParaBirimiID.DisplayMember = "ParaBirimi";
            cmbOdemeSekliID.DataSource = OdemeSekli;
            cmbMarkaID.ValueMember = "MarkaID";
            cmbMarkaID.DisplayMember = "MarkaAdi";
            cmbMarkaID.DataSource = arac.MarkaDoldur();
            cmbUrunID.ValueMember = "UrunID";
            cmbUrunID.DisplayMember = "UrunAdi";
            cmbUrunID.DataSource = arac.UrunDoldur();

        }
        private void FaturaEkle_Load(object sender, EventArgs e)
        {
            detaylar.Columns.Add("SNo", typeof(Int64));
            detaylar.Columns.Add("UrunID", typeof(Int64));
            detaylar.Columns.Add("UrunAdi", typeof(String));
            detaylar.Columns.Add("MarkaID", typeof(Int64));
            detaylar.Columns.Add("MarkaAdi", typeof(String));
            detaylar.Columns.Add("SiparisVerilenMiktar", typeof(Decimal));
            detaylar.Columns.Add("ToplamFiyati", typeof(Decimal));
            detaylar.Columns.Add("KDVOrani", typeof(Int32));
            detaylar.Columns.Add("KDVTutari", typeof(Decimal));
            detaylar.Columns.Add("GenelToplam", typeof(Decimal));
            detaylar.Columns.Add("UniqueID", typeof(string));
            cmbleriDoldur();
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    decimal dec;
                    int kdvo;
                    if (cmbUrunID.SelectedValue == "0" || cmbMarkaID.SelectedValue == "0" || string.IsNullOrEmpty(txtSiparisVerilenMiktar.Text) || string.IsNullOrEmpty(txtToplamFiyati.Text) || string.IsNullOrEmpty(cmbKDVOrani.SelectedText))
                    {
                        MessageBox.Show("Bütün Alanları Doldurmanız Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cmbUrunID.SelectedValue == null)
                    {
                        MessageBox.Show("Böyle Bir Ürün Bulunmamaktadır. Lütfen Önce Ürün Ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbMarkaID.SelectedValue == null)
                    {
                        MessageBox.Show("Böyle Bir Marka Bulunmamaktadır. Lütfen Önce Marka Ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!int.TryParse( cmbKDVOrani.SelectedText, out kdvo))
                    {
                        MessageBox.Show("Böyle Bir KDV Oranı Bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!decimal.TryParse(txtSiparisVerilenMiktar.Text, out dec) || !decimal.TryParse(txtToplamFiyati.Text, out dec))
                    {
                        MessageBox.Show("Birim Fiyat ve(ya) Sipariş Verilen Miktar Alanlarına Yanlış Veri Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        decimal miktar = Convert.ToDecimal(txtSiparisVerilenMiktar.Text);
                        decimal toplamfiyat = Convert.ToDecimal(txtToplamFiyati.Text);
                        int kdvoran = Convert.ToInt32(cmbKDVOrani.Text);
                        decimal kdv = toplamfiyat * kdvoran / 100;
                        decimal kdvlitoplam = toplamfiyat + kdv;

                        detaylar.Rows.Add(detaylar.Rows.Count + 1, Convert.ToInt64(cmbUrunID.SelectedValue), cmbUrunID.Text, Convert.ToInt64(cmbMarkaID.SelectedValue), cmbMarkaID.Text, miktar, toplamfiyat, kdvoran, kdv, kdvlitoplam, Guid.NewGuid().ToString());
                        grdDetaylar.DataSource = detaylar;
                        cmbUrunID.SelectedIndex = 0;
                        cmbMarkaID.SelectedIndex = 0;
                        txtToplamFiyati.Text = "";
                        txtSiparisVerilenMiktar.Text = "";
                        cmbKDVOrani.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    decimal dec;
                    if (cmbTedarikciID.SelectedValue == "0" || cmbOdemeSekliID.SelectedValue == "0" || string.IsNullOrEmpty(txtFaturaNo.Text) || cmbParaBirimiID.SelectedValue == "0")
                    {
                        MessageBox.Show("Bütün Alanları Doldurmanız Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbTedarikciID.SelectedValue == null)
                    {
                        MessageBox.Show("Böyle Bir Tedarikçi Bulunmamaktadır. Lütfen Önce Tedarikçi Ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbParaBirimiID.SelectedValue == null)
                    {
                        MessageBox.Show("Böyle Bir Para Birimi Bulunmamaktadır. Lütfen Önce Para Birimi Ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cmbOdemeSekliID.SelectedValue == null)
                    {
                        MessageBox.Show("Böyle Bir Ödeme Şekli Bulunmamaktadır. Lütfen Önce Ödeme Şekli Ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (!string.IsNullOrEmpty(txtKur.Text) && decimal.TryParse(txtKur.Text, out dec))
                    {
                        MessageBox.Show("Kur Alanı Yanlış Veri Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (detaylar == null || detaylar.Rows.Count == 0)
                    {
                        MessageBox.Show("En Az Bir Tane Fatura Detayı Girmeniz Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        FaturaEntity mainEntity = new FaturaEntity { Aciklama = txtAciklama.Text, FaturaNo = txtFaturaNo.Text, OdemeSekliID = Convert.ToInt64(cmbOdemeSekliID.SelectedValue), OdemeYapildimi = false, ParaBirimiID = Convert.ToInt64(cmbParaBirimiID.SelectedValue), TedarikciID = Convert.ToInt64(cmbTedarikciID.SelectedValue), FaturaTarihi = DateTime.Today };
                        if (!string.IsNullOrEmpty(txtKur.Text))
                            mainEntity.Kur = Convert.ToDecimal(txtKur.Text);
                        using (FaturaBS bs = new FaturaBS())
                        {
                            mainEntity.FaturaID = bs.Insert(mainEntity);
                            if (mainEntity.FaturaID > 0)
                            {
                                FaturaDetayEntity detay = new FaturaDetayEntity();
                                detay.FaturaID = mainEntity.FaturaID;
                                detay.TeslimAlindimi = false;
                                detay.GelenMiktar = 0;
                                foreach (DataRow dr in detaylar.Rows)
                                {
                                    using (FaturaDetayBS dbs = new FaturaDetayBS())
                                    {
                                        detay.BirimFiyati = Convert.ToDecimal(dr["ToplamFiyati"]);
                                        detay.KDVOrani = Convert.ToInt32(dr["KDVOrani"]);
                                        detay.SiparisVerilenMiktar = Convert.ToDecimal(dr["SiparisVerilenMiktar"]);
                                        detay.UrunID = Convert.ToInt64(dr["UrunID"]);
                                        detay.MarkaID = Convert.ToInt64(dr["MarkaID"]);
                                        if (!dbs.Insert(detay))
                                        {
                                            MessageBox.Show("Detay Eklenirken Hata Oluştu. Lütfen Tekrar Deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Fatura Eklenirken Hata Oluştu. Lütfen Tekrar Deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        f.GridDoldur();
                        
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

        private void cmbUrunID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunID.SelectedValue != "0")
            {
                using (Businness.UrunBS bs = new Businness.UrunBS())
                {
                    DataTable dt = bs.JoinListe(Convert.ToInt64(cmbUrunID.SelectedValue));
                    if (dt != null || dt.Rows.Count > 0)
                    {
                        lblBirim.Text = dt.Rows[0]["OlcuBirimi"].ToString();
                    }
                }
            }
            else
                lblBirim.Text = "";
        }

        private void grdDetaylar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (e.ColumnIndex == grdDetaylar.Columns["Sil"].Index)
                    {
                        string qid = grdDetaylar.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString();
                        DataRow secilen = detaylar.Rows.Cast<DataRow>().Where(x => x["UniqueID"].ToString() == grdDetaylar.Rows[e.RowIndex].Cells["UniqueID"].Value.ToString()).FirstOrDefault();
                        detaylar.Rows.Remove(secilen);
                        grdDetaylar.DataSource = detaylar;
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
