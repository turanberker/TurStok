namespace TurStok.Tanimlamalar
{
    partial class UrunTanimla
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
            this.grdOlcuBirimi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaklamaKosulu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AzamiMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaklamaKosuluID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiadVarmi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(902, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdOlcuBirimi
            // 
            this.grdOlcuBirimi.AllowUserToAddRows = false;
            this.grdOlcuBirimi.AllowUserToDeleteRows = false;
            this.grdOlcuBirimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOlcuBirimi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SNo,
            this.UrunAdi,
            this.KategoriAdi,
            this.SaklamaKosulu,
            this.AzamiMiktari,
            this.OlcuBirimi,
            this.SaklamaKosuluID,
            this.KategoriID,
            this.OlcuBirimiID,
            this.MiadVarmi});
            this.grdOlcuBirimi.Location = new System.Drawing.Point(12, 12);
            this.grdOlcuBirimi.Name = "grdOlcuBirimi";
            this.grdOlcuBirimi.ReadOnly = true;
            this.grdOlcuBirimi.Size = new System.Drawing.Size(995, 478);
            this.grdOlcuBirimi.TabIndex = 6;
            this.grdOlcuBirimi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOlcuBirimi_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "UrunID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 200;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 50;
            // 
            // UrunAdi
            // 
            this.UrunAdi.DataPropertyName = "UrunAdi";
            this.UrunAdi.HeaderText = "Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            this.UrunAdi.Width = 200;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.DataPropertyName = "KategoriAdi";
            this.KategoriAdi.HeaderText = "Kategorisi";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            this.KategoriAdi.Width = 200;
            // 
            // SaklamaKosulu
            // 
            this.SaklamaKosulu.DataPropertyName = "SaklamaKosulu";
            this.SaklamaKosulu.HeaderText = "Saklama Koşulu";
            this.SaklamaKosulu.Name = "SaklamaKosulu";
            this.SaklamaKosulu.ReadOnly = true;
            this.SaklamaKosulu.Width = 200;
            // 
            // AzamiMiktari
            // 
            this.AzamiMiktari.DataPropertyName = "AzamiMiktar";
            this.AzamiMiktari.HeaderText = "Azami Miktarı";
            this.AzamiMiktari.Name = "AzamiMiktari";
            this.AzamiMiktari.ReadOnly = true;
            // 
            // OlcuBirimi
            // 
            this.OlcuBirimi.DataPropertyName = "OlcuBirimi";
            this.OlcuBirimi.HeaderText = "Olcu Birimi";
            this.OlcuBirimi.Name = "OlcuBirimi";
            this.OlcuBirimi.ReadOnly = true;
            // 
            // SaklamaKosuluID
            // 
            this.SaklamaKosuluID.DataPropertyName = "SaklamaKosuluID";
            this.SaklamaKosuluID.HeaderText = "SaklamaKosuluID";
            this.SaklamaKosuluID.Name = "SaklamaKosuluID";
            this.SaklamaKosuluID.ReadOnly = true;
            this.SaklamaKosuluID.Visible = false;
            // 
            // KategoriID
            // 
            this.KategoriID.DataPropertyName = "KategoriID";
            this.KategoriID.HeaderText = "KategoriID";
            this.KategoriID.Name = "KategoriID";
            this.KategoriID.ReadOnly = true;
            this.KategoriID.Visible = false;
            // 
            // OlcuBirimiID
            // 
            this.OlcuBirimiID.DataPropertyName = "OlcuBirimID";
            this.OlcuBirimiID.HeaderText = "OlcuBirimiID";
            this.OlcuBirimiID.Name = "OlcuBirimiID";
            this.OlcuBirimiID.ReadOnly = true;
            this.OlcuBirimiID.Visible = false;
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
            // UrunTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 569);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Controls.Add(this.button1);
            this.Name = "UrunTanimla";
            this.Text = "Urun Tanımla";
            this.Load += new System.EventHandler(this.UrunTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaklamaKosulu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AzamiMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaklamaKosuluID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimiID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MiadVarmi;
    }
}