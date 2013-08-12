namespace TurStok
{
    partial class Faturalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdFatura = new System.Windows.Forms.DataGridView();
            this.FaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeSekliID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeSekli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeYapildimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OdemeYap = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdFaturaDetay = new System.Windows.Forms.DataGridView();
            this.cmbDurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTedarikciID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasTar = new System.Windows.Forms.MaskedTextBox();
            this.txtBitTar = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FaturaDetayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisVerilenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVDahil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimAlindimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdFatura)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFatura
            // 
            this.grdFatura.AllowUserToAddRows = false;
            this.grdFatura.AllowUserToDeleteRows = false;
            this.grdFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaID,
            this.SNo,
            this.FaturaNo,
            this.TedarikciID,
            this.TedarikciAdi,
            this.FaturaTarihi,
            this.Aciklama,
            this.ParaBirimID,
            this.ParaBirimi,
            this.OdemeSekliID,
            this.OdemeSekli,
            this.FaturaTutari,
            this.Kur,
            this.OdemeYapildimi,
            this.OdemeYap});
            this.grdFatura.Location = new System.Drawing.Point(7, 15);
            this.grdFatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdFatura.Name = "grdFatura";
            this.grdFatura.ReadOnly = true;
            this.grdFatura.Size = new System.Drawing.Size(1450, 325);
            this.grdFatura.TabIndex = 0;
            this.grdFatura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFatura_CellContentClick_1);
            // 
            // FaturaID
            // 
            this.FaturaID.DataPropertyName = "FaturaID";
            this.FaturaID.HeaderText = "FaturaID";
            this.FaturaID.Name = "FaturaID";
            this.FaturaID.ReadOnly = true;
            this.FaturaID.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // FaturaNo
            // 
            this.FaturaNo.DataPropertyName = "FaturaNo";
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.ReadOnly = true;
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "TedarikciID";
            this.TedarikciID.HeaderText = "TedarikciID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            this.TedarikciID.Visible = false;
            // 
            // TedarikciAdi
            // 
            this.TedarikciAdi.DataPropertyName = "TedarikciAdi";
            this.TedarikciAdi.HeaderText = "Tedarikçi Adı";
            this.TedarikciAdi.Name = "TedarikciAdi";
            this.TedarikciAdi.ReadOnly = true;
            this.TedarikciAdi.Width = 200;
            // 
            // FaturaTarihi
            // 
            this.FaturaTarihi.DataPropertyName = "FaturaTarihi";
            this.FaturaTarihi.HeaderText = "Fatura Tarihi";
            this.FaturaTarihi.Name = "FaturaTarihi";
            this.FaturaTarihi.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 300;
            // 
            // ParaBirimID
            // 
            this.ParaBirimID.DataPropertyName = "ParaBirimiID";
            this.ParaBirimID.HeaderText = "ParaBirimID";
            this.ParaBirimID.Name = "ParaBirimID";
            this.ParaBirimID.ReadOnly = true;
            this.ParaBirimID.Visible = false;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.DataPropertyName = "ParaBirimi";
            this.ParaBirimi.HeaderText = "Para Birimi";
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.ReadOnly = true;
            // 
            // OdemeSekliID
            // 
            this.OdemeSekliID.DataPropertyName = "OdemeSekliID";
            this.OdemeSekliID.HeaderText = "OdemeSekliID";
            this.OdemeSekliID.Name = "OdemeSekliID";
            this.OdemeSekliID.ReadOnly = true;
            this.OdemeSekliID.Visible = false;
            // 
            // OdemeSekli
            // 
            this.OdemeSekli.DataPropertyName = "OdemeSekli";
            this.OdemeSekli.HeaderText = "Odeme Şekli";
            this.OdemeSekli.Name = "OdemeSekli";
            this.OdemeSekli.ReadOnly = true;
            // 
            // FaturaTutari
            // 
            this.FaturaTutari.DataPropertyName = "FaturaTutari";
            this.FaturaTutari.HeaderText = "Fatura Tutarı";
            this.FaturaTutari.Name = "FaturaTutari";
            this.FaturaTutari.ReadOnly = true;
            // 
            // Kur
            // 
            this.Kur.DataPropertyName = "Kur";
            this.Kur.HeaderText = "Kur";
            this.Kur.Name = "Kur";
            this.Kur.ReadOnly = true;
            // 
            // OdemeYapildimi
            // 
            this.OdemeYapildimi.DataPropertyName = "OdemeYapildimi";
            this.OdemeYapildimi.FalseValue = "False";
            this.OdemeYapildimi.HeaderText = "Odeme Yapildimi";
            this.OdemeYapildimi.Name = "OdemeYapildimi";
            this.OdemeYapildimi.ReadOnly = true;
            this.OdemeYapildimi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OdemeYapildimi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OdemeYapildimi.TrueValue = "True";
            // 
            // OdemeYap
            // 
            this.OdemeYap.DataPropertyName = "FaturaID";
            this.OdemeYap.HeaderText = "Odeme Yap";
            this.OdemeYap.Name = "OdemeYap";
            this.OdemeYap.ReadOnly = true;
            this.OdemeYap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OdemeYap.Text = "Odeme Yap";
            this.OdemeYap.ToolTipText = "Odeme Yap";
            this.OdemeYap.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdFaturaDetay);
            this.groupBox1.Location = new System.Drawing.Point(15, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1354, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Detayları";
            this.groupBox1.Visible = false;
            // 
            // grdFaturaDetay
            // 
            this.grdFaturaDetay.AllowUserToAddRows = false;
            this.grdFaturaDetay.AllowUserToDeleteRows = false;
            this.grdFaturaDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFaturaDetay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaDetayID,
            this.DSNo,
            this.DFaturaID,
            this.UrunId,
            this.UrunAdi,
            this.MarkaID,
            this.MarkaAdi,
            this.SiparisVerilenMiktar,
            this.GelenMiktar,
            this.OlcuBirimi,
            this.BirimFiyati,
            this.ToplamFiyati,
            this.KDVOrani,
            this.KDV,
            this.KDVDahil,
            this.TeslimAlindimi});
            this.grdFaturaDetay.Location = new System.Drawing.Point(8, 37);
            this.grdFaturaDetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdFaturaDetay.Name = "grdFaturaDetay";
            this.grdFaturaDetay.ReadOnly = true;
            this.grdFaturaDetay.Size = new System.Drawing.Size(1244, 332);
            this.grdFaturaDetay.TabIndex = 0;
            // 
            // cmbDurumu
            // 
            this.cmbDurumu.FormattingEnabled = true;
            this.cmbDurumu.Items.AddRange(new object[] {
            "Hepsi",
            "Ödemesi Yapılmişlar",
            "Ödemesi Bekleyenler"});
            this.cmbDurumu.Location = new System.Drawing.Point(856, 385);
            this.cmbDurumu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDurumu.Name = "cmbDurumu";
            this.cmbDurumu.Size = new System.Drawing.Size(278, 24);
            this.cmbDurumu.TabIndex = 2;
            this.cmbDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbDurumu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura Durumunu Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tedarikçi Seçin";
            // 
            // cmbTedarikciID
            // 
            this.cmbTedarikciID.FormattingEnabled = true;
            this.cmbTedarikciID.Location = new System.Drawing.Point(23, 385);
            this.cmbTedarikciID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTedarikciID.Name = "cmbTedarikciID";
            this.cmbTedarikciID.Size = new System.Drawing.Size(248, 24);
            this.cmbTedarikciID.TabIndex = 5;
            this.cmbTedarikciID.SelectedIndexChanged += new System.EventHandler(this.cmbTedarikciID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sipariş Tarihi";
            // 
            // txtBasTar
            // 
            this.txtBasTar.Location = new System.Drawing.Point(301, 385);
            this.txtBasTar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasTar.Mask = "00.00.0000";
            this.txtBasTar.Name = "txtBasTar";
            this.txtBasTar.Size = new System.Drawing.Size(115, 23);
            this.txtBasTar.TabIndex = 7;
            this.txtBasTar.TextChanged += new System.EventHandler(this.txtBasTar_TextChanged);
            // 
            // txtBitTar
            // 
            this.txtBitTar.Location = new System.Drawing.Point(484, 385);
            this.txtBitTar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBitTar.Mask = "00.00.0000";
            this.txtBitTar.Name = "txtBitTar";
            this.txtBitTar.Size = new System.Drawing.Size(94, 23);
            this.txtBitTar.TabIndex = 9;
            this.txtBitTar.TextChanged += new System.EventHandler(this.txtBitTar_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1257, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fatura Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FaturaDetayID
            // 
            this.FaturaDetayID.DataPropertyName = "FaturaDetayID";
            this.FaturaDetayID.HeaderText = "FaturaDetayID";
            this.FaturaDetayID.Name = "FaturaDetayID";
            this.FaturaDetayID.ReadOnly = true;
            this.FaturaDetayID.Visible = false;
            // 
            // DSNo
            // 
            this.DSNo.DataPropertyName = "SNo";
            this.DSNo.HeaderText = "Sıra No";
            this.DSNo.Name = "DSNo";
            this.DSNo.ReadOnly = true;
            // 
            // DFaturaID
            // 
            this.DFaturaID.DataPropertyName = "FaturaID";
            this.DFaturaID.HeaderText = "DFaturaID";
            this.DFaturaID.Name = "DFaturaID";
            this.DFaturaID.ReadOnly = true;
            this.DFaturaID.Visible = false;
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunID";
            this.UrunId.HeaderText = "UrunID";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.Visible = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // MarkaID
            // 
            this.MarkaID.DataPropertyName = "MarkaID";
            this.MarkaID.HeaderText = "MarkaID";
            this.MarkaID.Name = "MarkaID";
            this.MarkaID.ReadOnly = true;
            this.MarkaID.Visible = false;
            // 
            // MarkaAdi
            // 
            this.MarkaAdi.DataPropertyName = "MarkaAdi";
            this.MarkaAdi.HeaderText = "Marka Adı";
            this.MarkaAdi.Name = "MarkaAdi";
            this.MarkaAdi.ReadOnly = true;
            // 
            // SiparisVerilenMiktar
            // 
            this.SiparisVerilenMiktar.DataPropertyName = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.HeaderText = "Sipariş Verilen Miktar";
            this.SiparisVerilenMiktar.Name = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.ReadOnly = true;
            // 
            // GelenMiktar
            // 
            this.GelenMiktar.DataPropertyName = "GelenMiktar";
            this.GelenMiktar.HeaderText = "Gelen Miktar";
            this.GelenMiktar.Name = "GelenMiktar";
            this.GelenMiktar.ReadOnly = true;
            // 
            // OlcuBirimi
            // 
            this.OlcuBirimi.DataPropertyName = "OlcuBirimi";
            this.OlcuBirimi.HeaderText = "Ölçü Birimi";
            this.OlcuBirimi.Name = "OlcuBirimi";
            this.OlcuBirimi.ReadOnly = true;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.DataPropertyName = "BirimFiyati";
            this.BirimFiyati.HeaderText = "Birim Fiyati";
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.ReadOnly = true;
            // 
            // ToplamFiyati
            // 
            this.ToplamFiyati.DataPropertyName = "ToplamFiyat";
            this.ToplamFiyati.HeaderText = "Toplam Fiyati";
            this.ToplamFiyati.Name = "ToplamFiyati";
            this.ToplamFiyati.ReadOnly = true;
            // 
            // KDVOrani
            // 
            this.KDVOrani.DataPropertyName = "KDVOrani";
            this.KDVOrani.HeaderText = "KDV Orani";
            this.KDVOrani.Name = "KDVOrani";
            this.KDVOrani.ReadOnly = true;
            // 
            // KDV
            // 
            this.KDV.DataPropertyName = "KDVTutari";
            this.KDV.HeaderText = "KDV";
            this.KDV.Name = "KDV";
            this.KDV.ReadOnly = true;
            // 
            // KDVDahil
            // 
            this.KDVDahil.DataPropertyName = "KDVDahil";
            this.KDVDahil.HeaderText = "Genel Toplam";
            this.KDVDahil.Name = "KDVDahil";
            this.KDVDahil.ReadOnly = true;
            // 
            // TeslimAlindimi
            // 
            this.TeslimAlindimi.DataPropertyName = "TeslimAlindimi";
            this.TeslimAlindimi.FalseValue = "False";
            this.TeslimAlindimi.HeaderText = "TeslimAlindimi";
            this.TeslimAlindimi.Name = "TeslimAlindimi";
            this.TeslimAlindimi.ReadOnly = true;
            this.TeslimAlindimi.TrueValue = "True";
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 864);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBitTar);
            this.Controls.Add(this.txtBasTar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTedarikciID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDurumu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdFatura);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.Faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFatura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFaturaDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdFaturaDetay;
        private System.Windows.Forms.ComboBox cmbDurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTedarikciID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBasTar;
        private System.Windows.Forms.MaskedTextBox txtBitTar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaBirimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeSekliID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeSekli;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OdemeYapildimi;
        private System.Windows.Forms.DataGridViewButtonColumn OdemeYap;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisVerilenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn GelenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVDahil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TeslimAlindimi;
    }
}