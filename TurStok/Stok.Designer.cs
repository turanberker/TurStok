namespace TurStok
{
    partial class Stok
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
            this.grdStok = new System.Windows.Forms.DataGridView();
            this.StokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaDetayIDgrd2ay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzamiMiktar2ay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTedarikci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdStok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdStok
            // 
            this.grdStok.AllowUserToAddRows = false;
            this.grdStok.AllowUserToDeleteRows = false;
            this.grdStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokID,
            this.FaturaDetayIDgrd2ay,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn26,
            this.AzamiMiktar2ay});
            this.grdStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdStok.Location = new System.Drawing.Point(0, 0);
            this.grdStok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdStok.Name = "grdStok";
            this.grdStok.ReadOnly = true;
            this.grdStok.Size = new System.Drawing.Size(976, 533);
            this.grdStok.TabIndex = 25;
            this.grdStok.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStok_CellContentDoubleClick);
            // 
            // StokID
            // 
            this.StokID.DataPropertyName = "StokID";
            this.StokID.HeaderText = "StokID";
            this.StokID.Name = "StokID";
            this.StokID.ReadOnly = true;
            this.StokID.Visible = false;
            // 
            // FaturaDetayIDgrd2ay
            // 
            this.FaturaDetayIDgrd2ay.DataPropertyName = "FaturaDetayID";
            this.FaturaDetayIDgrd2ay.HeaderText = "FaturaDetayID";
            this.FaturaDetayIDgrd2ay.Name = "FaturaDetayIDgrd2ay";
            this.FaturaDetayIDgrd2ay.ReadOnly = true;
            this.FaturaDetayIDgrd2ay.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SNo";
            this.dataGridViewTextBoxColumn15.HeaderText = "Sıra No";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UrunAdi";
            this.dataGridViewTextBoxColumn16.HeaderText = "Urun Adi";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 130;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "KategoriAdi";
            this.dataGridViewTextBoxColumn19.HeaderText = "Kategori Adi";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "MarkaAdi";
            this.dataGridViewTextBoxColumn22.HeaderText = "Marka Adi";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TedarikciAdi";
            this.dataGridViewTextBoxColumn23.HeaderText = "Tedarikci Adi";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "GelisTarihi";
            this.dataGridViewTextBoxColumn25.HeaderText = "Geliş Tarihi";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SonKullanmaTarihi";
            this.dataGridViewTextBoxColumn17.HeaderText = "Son Kullanma Tarihi";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "KalanMiktar";
            this.dataGridViewTextBoxColumn18.HeaderText = "Kalan Miktar";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "OlcuBirimi";
            this.dataGridViewTextBoxColumn24.HeaderText = "Ölçü Birimi";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 70;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "DepoAdi";
            this.dataGridViewTextBoxColumn20.HeaderText = "Bulunduğu Depo";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "DepoID";
            this.dataGridViewTextBoxColumn21.HeaderText = "DepoID1ay";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "MiadVarmi";
            this.dataGridViewTextBoxColumn26.HeaderText = "MiadVarmi";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // AzamiMiktar2ay
            // 
            this.AzamiMiktar2ay.DataPropertyName = "AzamiMiktar";
            this.AzamiMiktar2ay.HeaderText = "AzamiMiktar2ay";
            this.AzamiMiktar2ay.Name = "AzamiMiktar2ay";
            this.AzamiMiktar2ay.ReadOnly = true;
            this.AzamiMiktar2ay.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 533);
            this.splitter1.TabIndex = 27;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(3, 397);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(973, 136);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter2_SplitterMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(10, 59);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 23);
            this.txtAdi.TabIndex = 1;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategorisi";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(148, 59);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(100, 23);
            this.txtKategori.TabIndex = 2;
            this.txtKategori.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Markasi";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(291, 59);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 23);
            this.txtMarka.TabIndex = 3;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tedirikcisi";
            // 
            // txtTedarikci
            // 
            this.txtTedarikci.Location = new System.Drawing.Point(427, 59);
            this.txtTedarikci.Name = "txtTedarikci";
            this.txtTedarikci.Size = new System.Drawing.Size(100, 23);
            this.txtTedarikci.TabIndex = 4;
            this.txtTedarikci.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bulunduğu Depo";
            // 
            // txtDepo
            // 
            this.txtDepo.Location = new System.Drawing.Point(561, 59);
            this.txtDepo.Name = "txtDepo";
            this.txtDepo.Size = new System.Drawing.Size(100, 23);
            this.txtDepo.TabIndex = 5;
            this.txtDepo.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDepo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTedarikci);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 397);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(961, 123);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grdStok);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Stok";
            this.Text = "Stok";
            ((System.ComponentModel.ISupportInitialize)(this.grdStok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTedarikci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayIDgrd2ay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzamiMiktar2ay;
        private System.Windows.Forms.DataGridView grdStok;

    }
}