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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeYapildimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FaturaDetayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisVerilenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVOrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaID,
            this.FaturaNo,
            this.TedarikciID,
            this.TedarikciAdi,
            this.SiparisTarihi,
            this.Aciklama,
            this.ParaBirimID,
            this.Kur,
            this.OdemeYapildimi});
            this.dataGridView1.Location = new System.Drawing.Point(7, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1356, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // FaturaID
            // 
            this.FaturaID.HeaderText = "FaturaID";
            this.FaturaID.Name = "FaturaID";
            this.FaturaID.ReadOnly = true;
            this.FaturaID.Visible = false;
            // 
            // FaturaNo
            // 
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.ReadOnly = true;
            // 
            // TedarikciID
            // 
            this.TedarikciID.HeaderText = "TedarikciID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            this.TedarikciID.Visible = false;
            // 
            // TedarikciAdi
            // 
            this.TedarikciAdi.HeaderText = "Tedarikçi Adı";
            this.TedarikciAdi.Name = "TedarikciAdi";
            this.TedarikciAdi.ReadOnly = true;
            // 
            // SiparisTarihi
            // 
            this.SiparisTarihi.HeaderText = "Sipariş Tarihi";
            this.SiparisTarihi.Name = "SiparisTarihi";
            this.SiparisTarihi.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // ParaBirimID
            // 
            this.ParaBirimID.HeaderText = "ParaBirimID";
            this.ParaBirimID.Name = "ParaBirimID";
            this.ParaBirimID.ReadOnly = true;
            this.ParaBirimID.Visible = false;
            // 
            // Kur
            // 
            this.Kur.HeaderText = "Kur";
            this.Kur.Name = "Kur";
            this.Kur.ReadOnly = true;
            // 
            // OdemeYapildimi
            // 
            this.OdemeYapildimi.HeaderText = "Odeme Yapildimi";
            this.OdemeYapildimi.Name = "OdemeYapildimi";
            this.OdemeYapildimi.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(15, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1354, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Detayları";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaDetayID,
            this.UrunId,
            this.UrunAdi,
            this.MarkaID,
            this.MarkaAdi,
            this.SiparisVerilenMiktar,
            this.OlcuBirimiID,
            this.OlcuBirimi,
            this.BirimFiyati,
            this.ToplamFiyati,
            this.KDVOrani,
            this.KDV});
            this.dataGridView2.Location = new System.Drawing.Point(8, 37);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1339, 332);
            this.dataGridView2.TabIndex = 0;
            // 
            // FaturaDetayID
            // 
            this.FaturaDetayID.HeaderText = "FaturaDetayID";
            this.FaturaDetayID.Name = "FaturaDetayID";
            this.FaturaDetayID.Visible = false;
            // 
            // UrunId
            // 
            this.UrunId.HeaderText = "UrunID";
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // MarkaID
            // 
            this.MarkaID.HeaderText = "MarkaID";
            this.MarkaID.Name = "MarkaID";
            this.MarkaID.Visible = false;
            // 
            // MarkaAdi
            // 
            this.MarkaAdi.HeaderText = "Marka Adı";
            this.MarkaAdi.Name = "MarkaAdi";
            // 
            // SiparisVerilenMiktar
            // 
            this.SiparisVerilenMiktar.HeaderText = "Sipariş Verilen Miktar";
            this.SiparisVerilenMiktar.Name = "SiparisVerilenMiktar";
            // 
            // OlcuBirimiID
            // 
            this.OlcuBirimiID.HeaderText = "OlcuBirimiID";
            this.OlcuBirimiID.Name = "OlcuBirimiID";
            this.OlcuBirimiID.Visible = false;
            // 
            // OlcuBirimi
            // 
            this.OlcuBirimi.HeaderText = "Ölçü Birimi";
            this.OlcuBirimi.Name = "OlcuBirimi";
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.HeaderText = "Birim Fiyati";
            this.BirimFiyati.Name = "BirimFiyati";
            // 
            // ToplamFiyati
            // 
            this.ToplamFiyati.HeaderText = "Toplam Fiyati";
            this.ToplamFiyati.Name = "ToplamFiyati";
            // 
            // KDVOrani
            // 
            this.KDVOrani.HeaderText = "KDV Orani";
            this.KDVOrani.Name = "KDVOrani";
            // 
            // KDV
            // 
            this.KDV.HeaderText = "KDV";
            this.KDV.Name = "KDV";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hepsi",
            "Ödemesi Yapılmişlar",
            "Ödemesi Bekleyenler"});
            this.comboBox1.Location = new System.Drawing.Point(856, 385);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura Durumunu Seçin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 385);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sipariş Tarihi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(301, 385);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBox1.Mask = "00.00.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(115, 23);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(484, 385);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBox2.Mask = "00.00.0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(94, 23);
            this.maskedTextBox2.TabIndex = 9;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1250, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fatura Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 864);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaBirimID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kur;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeYapildimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisVerilenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
    }
}