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
            this.FaturaDetayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisVerilenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiadVarmi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.turStokDataSet = new TurStok.TurStokDataSet();
            this.depoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoTableAdapter = new TurStok.TurStokDataSetTableAdapters.DepoTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGelenMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSonTarih = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepoID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBeklenen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turStokDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.OlcuBirimiID,
            this.TedarikciID,
            this.MarkaAdi,
            this.SiparisVerilenMiktar,
            this.OlcuBirimi,
            this.MiadVarmi,
            this.Gir});
            this.grdBeklenen.Location = new System.Drawing.Point(14, 16);
            this.grdBeklenen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grdBeklenen.Name = "grdBeklenen";
            this.grdBeklenen.ReadOnly = true;
            this.grdBeklenen.Size = new System.Drawing.Size(746, 409);
            this.grdBeklenen.TabIndex = 1;
            this.grdBeklenen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFaturaDetay_CellContentClick);
            // 
            // FaturaDetayID
            // 
            this.FaturaDetayID.DataPropertyName = "FaturaDetayID";
            this.FaturaDetayID.HeaderText = "FaturaDetayID";
            this.FaturaDetayID.Name = "FaturaDetayID";
            this.FaturaDetayID.ReadOnly = true;
            this.FaturaDetayID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FaturaDetayID.Visible = false;
            // 
            // DSNo
            // 
            this.DSNo.DataPropertyName = "SNo";
            this.DSNo.HeaderText = "Sıra No";
            this.DSNo.Name = "DSNo";
            this.DSNo.ReadOnly = true;
            this.DSNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UrunId
            // 
            this.UrunId.DataPropertyName = "UrunID";
            this.UrunId.HeaderText = "UrunID";
            this.UrunId.Name = "UrunId";
            this.UrunId.ReadOnly = true;
            this.UrunId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UrunId.Visible = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            this.UrunAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MarkaID
            // 
            this.MarkaID.DataPropertyName = "MarkaID";
            this.MarkaID.HeaderText = "MarkaID";
            this.MarkaID.Name = "MarkaID";
            this.MarkaID.ReadOnly = true;
            this.MarkaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MarkaID.Visible = false;
            // 
            // OlcuBirimiID
            // 
            this.OlcuBirimiID.DataPropertyName = "OlcuBirimiID";
            this.OlcuBirimiID.HeaderText = "OlcuBirimiID";
            this.OlcuBirimiID.Name = "OlcuBirimiID";
            this.OlcuBirimiID.ReadOnly = true;
            this.OlcuBirimiID.Visible = false;
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "TedarikciID";
            this.TedarikciID.HeaderText = "TedarikciID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            this.TedarikciID.Visible = false;
            // 
            // MarkaAdi
            // 
            this.MarkaAdi.DataPropertyName = "MarkaAdi";
            this.MarkaAdi.HeaderText = "Marka Adı";
            this.MarkaAdi.Name = "MarkaAdi";
            this.MarkaAdi.ReadOnly = true;
            this.MarkaAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SiparisVerilenMiktar
            // 
            this.SiparisVerilenMiktar.DataPropertyName = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.HeaderText = "Sipariş Verilen Miktar";
            this.SiparisVerilenMiktar.Name = "SiparisVerilenMiktar";
            this.SiparisVerilenMiktar.ReadOnly = true;
            this.SiparisVerilenMiktar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OlcuBirimi
            // 
            this.OlcuBirimi.DataPropertyName = "OlcuBirimi";
            this.OlcuBirimi.HeaderText = "Ölçü Birimi";
            this.OlcuBirimi.Name = "OlcuBirimi";
            this.OlcuBirimi.ReadOnly = true;
            this.OlcuBirimi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MiadVarmi
            // 
            this.MiadVarmi.DataPropertyName = "MiadVarmi";
            this.MiadVarmi.FalseValue = "False";
            this.MiadVarmi.HeaderText = "Miad Varmi";
            this.MiadVarmi.Name = "MiadVarmi";
            this.MiadVarmi.ReadOnly = true;
            this.MiadVarmi.TrueValue = "True";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGelenMiktar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSonTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepoID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 434);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(645, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Bilgileri";
            // 
            // txtGelenMiktar
            // 
            this.txtGelenMiktar.Location = new System.Drawing.Point(330, 57);
            this.txtGelenMiktar.Name = "txtGelenMiktar";
            this.txtGelenMiktar.Size = new System.Drawing.Size(156, 23);
            this.txtGelenMiktar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gelen miktar (Beklenenden Farklıysa Doldurun)";
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Location = new System.Drawing.Point(179, 58);
            this.txtSonTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSonTarih.Mask = "00.00.0000";
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(123, 23);
            this.txtSonTarih.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Kullanım Tarihi";
            // 
            // cmbDepoID
            // 
            this.cmbDepoID.FormattingEnabled = true;
            this.cmbDepoID.Location = new System.Drawing.Point(10, 58);
            this.cmbDepoID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepoID.Name = "cmbDepoID";
            this.cmbDepoID.Size = new System.Drawing.Size(149, 24);
            this.cmbDepoID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depo Adı";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(24, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Faturasız Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StokGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdBeklenen);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StokGirisi";
            this.Text = "Stok Girişi";
            this.Load += new System.EventHandler(this.StokGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBeklenen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turStokDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBeklenen;
        private TurStokDataSet turStokDataSet;
        private System.Windows.Forms.BindingSource depoBindingSource;
        private TurStokDataSetTableAdapters.DepoTableAdapter depoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGelenMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtSonTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisVerilenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MiadVarmi;
        private System.Windows.Forms.DataGridViewButtonColumn Gir;
        private System.Windows.Forms.Button button1;
    }
}