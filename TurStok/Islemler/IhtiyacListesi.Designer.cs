namespace TurStok.Islemler
{
    partial class İhtiyacListesi
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
            this.button1 = new System.Windows.Forms.Button();
            this.grdIhtiyacListesi = new System.Windows.Forms.DataGridView();
            this.cmbUrunID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdIhtiyacListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(571, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdIhtiyacListesi
            // 
            this.grdIhtiyacListesi.AllowUserToAddRows = false;
            this.grdIhtiyacListesi.AllowUserToDeleteRows = false;
            this.grdIhtiyacListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIhtiyacListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SNo,
            this.UrunAdi,
            this.KategoriAdi,
            this.Tarih,
            this.Sil});
            this.grdIhtiyacListesi.Location = new System.Drawing.Point(12, 12);
            this.grdIhtiyacListesi.Name = "grdIhtiyacListesi";
            this.grdIhtiyacListesi.ReadOnly = true;
            this.grdIhtiyacListesi.Size = new System.Drawing.Size(646, 478);
            this.grdIhtiyacListesi.TabIndex = 4;
            this.grdIhtiyacListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIhtiyacListesi_CellContentClick);
            // 
            // cmbUrunID
            // 
            this.cmbUrunID.FormattingEnabled = true;
            this.cmbUrunID.Location = new System.Drawing.Point(12, 523);
            this.cmbUrunID.Name = "cmbUrunID";
            this.cmbUrunID.Size = new System.Drawing.Size(255, 21);
            this.cmbUrunID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eklenecek Ürün";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "UrunID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            this.UrunAdi.Width = 200;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "Kategori Adi";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            // 
            // Sil
            // 
            this.Sil.DataPropertyName = "UrunID";
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            this.Sil.ReadOnly = true;
            this.Sil.Text = "Sil";
            this.Sil.UseColumnTextForButtonValue = true;
            // 
            // İhtiyacListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdIhtiyacListesi);
            this.Name = "İhtiyacListesi";
            this.Text = "İhtiyaç Listesi";
            this.Load += new System.EventHandler(this.İhtiyacListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdIhtiyacListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdIhtiyacListesi;
        private System.Windows.Forms.ComboBox cmbUrunID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;

    }
}