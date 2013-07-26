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

namespace TurStok.Islemler
{
    public partial class FaturaEkle : Form
    {
        public FaturaEkle()
        {
            InitializeComponent();
        }
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
            detaylar.Columns.Add("BirimFiyati", typeof(Decimal));
            detaylar.Columns.Add("ToplamFiyati", typeof(Decimal));
            detaylar.Columns.Add("KDVOrani", typeof(Int32));
            detaylar.Columns.Add("KDVTutari", typeof(Decimal));
            detaylar.Columns.Add("GenelToplam", typeof(Decimal));
            cmbleriDoldur();
        }

        private void btnDetayEkle_Click(object sender, EventArgs e)
        {
            decimal dec;
            if (cmbUrunID.SelectedValue == "0" || cmbMarkaID.SelectedValue == "0" || string.IsNullOrEmpty(txtSiparisVerilenMiktar.Text) || string.IsNullOrEmpty(txtBirimFiyati.Text) || !string.IsNullOrEmpty(cmbKDVOrani.SelectedText))
            {
                MessageBox.Show("Bütün Alanları Doldurmanız Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!decimal.TryParse(txtSiparisVerilenMiktar.Text, out dec) || !decimal.TryParse(txtBirimFiyati.Text, out dec))
            {
                MessageBox.Show("Birim Fiyat ve(ya) Sipariş Verilen Miktar Alanlarına Yanlış Veri Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal bf = Convert.ToDecimal(txtBirimFiyati.Text);
                decimal miktar = Convert.ToDecimal(txtSiparisVerilenMiktar.Text);
                decimal toplamfiyat = bf * miktar;
                int kdvoran = Convert.ToInt32(cmbKDVOrani.Text);
                decimal kdv = toplamfiyat * kdvoran / 100;
                decimal kdvlitoplam = toplamfiyat + kdv;

                detaylar.Rows.Add(detaylar.Rows.Count + 1, Convert.ToInt64(cmbUrunID.SelectedValue), cmbUrunID.Text, Convert.ToInt64(cmbMarkaID.SelectedValue), cmbMarkaID.Text, miktar, bf, toplamfiyat, kdvoran, kdv, kdvlitoplam);
                grdDetaylar.DataSource = detaylar;
                cmbUrunID.SelectedIndex = 0;
                cmbMarkaID.SelectedIndex = 0;
                txtBirimFiyati.Text = "";
                txtSiparisVerilenMiktar.Text = "";
                cmbKDVOrani.SelectedIndex = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal dec;
            if (cmbTedarikciID.SelectedValue == "0" || cmbOdemeSekliID.SelectedValue == "0" || string.IsNullOrEmpty(txtFaturaNo.Text) || cmbParaBirimiID.SelectedValue == "0")
            {
                MessageBox.Show("Bütün Alanları Doldurmanız Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(txtKur.Text) && decimal.TryParse(txtKur.Text, out dec))
            {
                MessageBox.Show("Kur Alanı Yanlış Veri Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (detaylar == null || detaylar.Rows.Count == 0)
            {
                MessageBox.Show("En Az Bir Tane Fatura Detayı Girmeniz Gerekmektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                detay.BirimFiyati = Convert.ToDecimal(dr["BirimFiyati"]);
                                detay.KDVOrani = Convert.ToInt32(dr["KDVOrani"]);
                                detay.SiparisVerilenMiktar = Convert.ToDecimal(dr["SiparisVerilenMiktar"]);
                                detay.UrunID = Convert.ToInt64(dr["UrunID"]);
                                detay.MarkaID = Convert.ToInt64(dr["MarkaID"]);
                                dbs.Insert(detay);
                            }

                        }
                    }
                }
                MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Faturalar f = new Faturalar();
                f.GridDoldur();
                this.Close();
            }

        }
    }
}