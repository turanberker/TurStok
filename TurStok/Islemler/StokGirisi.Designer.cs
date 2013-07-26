namespace TurStok.Islemler
{
    partial class StokGirisi
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
            this.components = new System.ComponentModel.Container();
            this.grdBeklenen = new System.Windows.Forms.DataGridView();
            this.turStokDataSet = new TurStok.TurStokDataSet();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoTableAdapter = new TurStok.TurStokDataSetTableAdapters.DepoTableAdapter();
            this.FaturaDetayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisVerilenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GelenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeslimAlindimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBeklenen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turStokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBeklenen
            // 
            this.grdBeklenen.AllowUserToAddRows = false;
            this.grdBeklenen.AllowUserToDeleteRows = false;
            this.grdBeklenen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBeklenen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaDetayID,
            this.DSNo,
            this.UrunId,
            this.UrunAdi,
            this.MarkaID,
            this.MarkaAdi,
            this.SiparisVerilenMiktar,
            this.GelenMiktar,
            this.OlcuBirimi,
            this.TeslimAlindimi,
            this.Gir,
            this.Column1});
            this.grdBeklenen.Location = new System.Drawing.Point(12, 13);
            this.grdBeklenen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdBeklenen.Name = "grdBeklenen";
            this.grdBeklenen.Size = new System.Drawing.Size(996, 332);
            this.grdBeklenen.TabIndex = 1;
            this.grdBeklenen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFaturaDetay_CellContentClick);
            // 
            // turStokDataSet
            // 
            this.turStokDataSet.DataSetName = "TurStokDataSet";
            this.turStokDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoBindingSource
            // 
            this.depoBindingSource.DataMember = "Depo";
            this.depoBindingSource.DataSource = this.turStokDataSet;
            // 
            // depoTableAdapter
            // 
            this.depoTableAdapter.ClearBeforeFill = true;
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
            // TeslimAlindimi
            // 
            this.TeslimAlindimi.DataPropertyName = "TeslimAlindimi";
            this.TeslimAlindimi.FalseValue = "False";
            this.TeslimAlindimi.HeaderText = "TeslimAlindimi";
            this.TeslimAlindimi.Name = "TeslimAlindimi";
            this.TeslimAlindimi.ReadOnly = true;
            this.TeslimAlindimi.TrueValue = "True";
            // 
            // Gir
            // 
            this.Gir.DataPropertyName = "FaturaDetayID";
            this.Gir.HeaderText = "Teslim Al";
            this.Gir.Name = "Gir";
            this.Gir.ReadOnly = true;
            this.Gir.Text = "Teslim Al";
            this.Gir.ToolTipText = "Teslim Al";
            this.Gir.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // StokGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 532);
            this.Controls.Add(this.grdBeklenen);
            this.Name = "StokGirisi";
            this.Text = "Stok Girişi";
            this.Load += new System.EventHandler(this.StokGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBeklenen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turStokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBeklenen;
        private TurStokDataSet turStokDataSet;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private TurStokDataSetTableAdapters.DepoTableAdapter depoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisVerilenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn GelenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TeslimAlindimi;
        private System.Windows.Forms.DataGridViewButtonColumn Gir;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
    }
}