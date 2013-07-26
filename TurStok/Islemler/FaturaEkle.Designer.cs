namespace TurStok.Islemler
{
    partial class FaturaEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOdemeSekliID = new System.Windows.Forms.ComboBox();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.cmbParaBirimiID = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbTedarikciID = new System.Windows.Forms.ComboBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDetaylar = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetayEkle = new System.Windows.Forms.Button();
            this.cmbKDVOrani = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSiparisVerilenMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMarkaID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUrunID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisVerilenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetaylar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOdemeSekliID);
            this.groupBox1.Controls.Add(this.txtKur);
            this.groupBox1.Controls.Add(this.cmbParaBirimiID);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.cmbTedarikciID);
            this.groupBox1.Controls.Add(this.txtFaturaNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(986, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Bilgileri";
            // 
            // cmbOdemeSekliID
            // 
            this.cmbOdemeSekliID.FormattingEnabled = true;
            this.cmbOdemeSekliID.Location = new System.Drawing.Point(741, 54);
            this.cmbOdemeSekliID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOdemeSekliID.Name = "cmbOdemeSekliID";
            this.cmbOdemeSekliID.Size = new System.Drawing.Size(168, 24);
            this.cmbOdemeSekliID.TabIndex = 11;
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(617, 55);
            this.txtKur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKur.MaxLength = 200;
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(116, 23);
            this.txtKur.TabIndex = 10;
            // 
            // cmbParaBirimiID
            // 
            this.cmbParaBirimiID.FormattingEnabled = true;
            this.cmbParaBirimiID.Location = new System.Drawing.Point(441, 55);
            this.cmbParaBirimiID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbParaBirimiID.Name = "cmbParaBirimiID";
            this.cmbParaBirimiID.Size = new System.Drawing.Size(168, 24);
            this.cmbParaBirimiID.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(317, 58);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAciklama.MaxLength = 200;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(116, 23);
            this.txtAciklama.TabIndex = 8;
            // 
            // cmbTedarikciID
            // 
            this.cmbTedarikciID.FormattingEnabled = true;
            this.cmbTedarikciID.Location = new System.Drawing.Point(141, 58);
            this.cmbTedarikciID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTedarikciID.Name = "cmbTedarikciID";
            this.cmbTedarikciID.Size = new System.Drawing.Size(168, 24);
            this.cmbTedarikciID.TabIndex = 7;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(12, 59);
            this.txtFaturaNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFaturaNo.MaxLength = 20;
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(116, 23);
            this.txtFaturaNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ödeme Şekli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Para Birimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No";
            // 
            // grdDetaylar
            // 
            this.grdDetaylar.AllowUserToAddRows = false;
            this.grdDetaylar.AllowUserToDeleteRows = false;
            this.grdDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetaylar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.UrunID,
            this.UrunAdi,
            this.MarkaID,
            this.MarkaAdi,
            this.SiparisVerilenMiktar,
            this.BirimFiyati,
            this.ToplamFiyati,
            this.KDVOrani,
            this.KDVTutari,
            this.GenelToplam});
            this.grdDetaylar.Location = new System.Drawing.Point(15, 149);
            this.grdDetaylar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdDetaylar.Name = "grdDetaylar";
            this.grdDetaylar.ReadOnly = true;
            this.grdDetaylar.Size = new System.Drawing.Size(986, 185);
            this.grdDetaylar.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDetayEkle);
            this.groupBox2.Controls.Add(this.cmbKDVOrani);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBirimFiyati);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSiparisVerilenMiktar);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbMarkaID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbUrunID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 375);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(986, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fatura Detayı Ekle";
            // 
            // btnDetayEkle
            // 
            this.btnDetayEkle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetayEkle.Location = new System.Drawing.Point(12, 100);
            this.btnDetayEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetayEkle.Name = "btnDetayEkle";
            this.btnDetayEkle.Size = new System.Drawing.Size(96, 58);
            this.btnDetayEkle.TabIndex = 18;
            this.btnDetayEkle.Text = "Detay Ekle";
            this.btnDetayEkle.UseVisualStyleBackColor = true;
            this.btnDetayEkle.Click += new System.EventHandler(this.btnDetayEkle_Click);
            // 
            // cmbKDVOrani
            // 
            this.cmbKDVOrani.FormattingEnabled = true;
            this.cmbKDVOrani.Items.AddRange(new object[] {
            "0",
            "1",
            "8",
            "18"});
            this.cmbKDVOrani.Location = new System.Drawing.Point(617, 65);
            this.cmbKDVOrani.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKDVOrani.Name = "cmbKDVOrani";
            this.cmbKDVOrani.Size = new System.Drawing.Size(168, 24);
            this.cmbKDVOrani.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(614, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "KDV Oranı";
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(493, 66);
            this.txtBirimFiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBirimFiyati.MaxLength = 20;
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(116, 23);
            this.txtBirimFiyati.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Birim Fiyatı";
            // 
            // txtSiparisVerilenMiktar
            // 
            this.txtSiparisVerilenMiktar.Location = new System.Drawing.Point(364, 66);
            this.txtSiparisVerilenMiktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSiparisVerilenMiktar.MaxLength = 20;
            this.txtSiparisVerilenMiktar.Name = "txtSiparisVerilenMiktar";
            this.txtSiparisVerilenMiktar.Size = new System.Drawing.Size(116, 23);
            this.txtSiparisVerilenMiktar.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sipariş Verilen Miktar";
            // 
            // cmbMarkaID
            // 
            this.cmbMarkaID.FormattingEnabled = true;
            this.cmbMarkaID.Location = new System.Drawing.Point(188, 66);
            this.cmbMarkaID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMarkaID.Name = "cmbMarkaID";
            this.cmbMarkaID.Size = new System.Drawing.Size(168, 24);
            this.cmbMarkaID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Marka";
            // 
            // cmbUrunID
            // 
            this.cmbUrunID.FormattingEnabled = true;
            this.cmbUrunID.Location = new System.Drawing.Point(12, 66);
            this.cmbUrunID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUrunID.Name = "cmbUrunID";
            this.cmbUrunID.Size = new System.Drawing.Size(168, 24);
            this.cmbUrunID.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ürün Adı";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(397, 559);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Faturayı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 50;
            // 
            // UrunID
            // 
            this.UrunID.DataPropertyName = "UrunID";
            this.UrunID.HeaderText = "UrunID";
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            this.UrunID.Visible = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Urun Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            this.UrunAdi.Width = 150;
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
            this.MarkaAdi.Width = 150;
            // 
            // SiparisVerilenMiktar
            // 
            this.SiparisVerilenMiktar.DataPropertyName = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.HeaderText = "Sipariş Verilen Miktar";
            this.SiparisVerilenMiktar.Name = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.ReadOnly = true;
            this.SiparisVerilenMiktar.Width = 150;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.DataPropertyName = "BirimFiyati";
            this.BirimFiyati.HeaderText = "BirimFiyati";
            this.BirimFiyati.Name = "BirimFiyati";
            this.BirimFiyati.ReadOnly = true;
            this.BirimFiyati.Width = 110;
            // 
            // ToplamFiyati
            // 
            this.ToplamFiyati.DataPropertyName = "ToplamFiyati";
            this.ToplamFiyati.HeaderText = "Toplam Fiyati";
            this.ToplamFiyati.Name = "ToplamFiyati";
            this.ToplamFiyati.ReadOnly = true;
            this.ToplamFiyati.Width = 110;
            // 
            // KDVOrani
            // 
            this.KDVOrani.DataPropertyName = "KDVOrani";
            this.KDVOrani.HeaderText = "KdvOranı";
            this.KDVOrani.Name = "KDVOrani";
            this.KDVOrani.ReadOnly = true;
            this.KDVOrani.Visible = false;
            // 
            // KDVTutari
            // 
            this.KDVTutari.DataPropertyName = "KDVTutari";
            this.KDVTutari.HeaderText = "KDV Tutarı";
            this.KDVTutari.Name = "KDVTutari";
            this.KDVTutari.ReadOnly = true;
            this.KDVTutari.Width = 110;
            // 
            // GenelToplam
            // 
            this.GenelToplam.DataPropertyName = "GenelToplam";
            this.GenelToplam.HeaderText = "Genel Toplam";
            this.GenelToplam.Name = "GenelToplam";
            this.GenelToplam.ReadOnly = true;
            this.GenelToplam.Width = 110;
            // 
            // FaturaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdDetaylar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FaturaEkle";
            this.Text = "Fatura Ekle";
            this.Load += new System.EventHandler(this.FaturaEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetaylar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbOdemeSekliID;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.ComboBox cmbParaBirimiID;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbTedarikciID;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDetaylar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDetayEkle;
        private System.Windows.Forms.ComboBox cmbKDVOrani;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSiparisVerilenMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMarkaID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUrunID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisVerilenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelToplam;

    }
}