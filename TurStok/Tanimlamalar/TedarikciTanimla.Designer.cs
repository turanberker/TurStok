namespace TurStok.Tanimlamalar
{
    partial class TedarikciTanimla
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
            this.grdOlcuBirimi = new System.Windows.Forms.DataGridView();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TedarikciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EklenmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YurtIcimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOlcuBirimi
            // 
            this.grdOlcuBirimi.AllowUserToAddRows = false;
            this.grdOlcuBirimi.AllowUserToDeleteRows = false;
            this.grdOlcuBirimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOlcuBirimi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TedarikciID,
            this.SNo,
            this.TedarikciAdi,
            this.Telefon,
            this.Faks,
            this.EMail,
            this.Adres,
            this.IBAN,
            this.BankaHesapNo,
            this.EklenmeTarihi,
            this.YurtIcimi});
            this.grdOlcuBirimi.Location = new System.Drawing.Point(12, 12);
            this.grdOlcuBirimi.Name = "grdOlcuBirimi";
            this.grdOlcuBirimi.ReadOnly = true;
            this.grdOlcuBirimi.Size = new System.Drawing.Size(1295, 478);
            this.grdOlcuBirimi.TabIndex = 4;
            this.grdOlcuBirimi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOlcuBirimi_CellContentDoubleClick);
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "TedarikciID";
            this.TedarikciID.HeaderText = "ID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            this.TedarikciID.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 50;
            // 
            // TedarikciAdi
            // 
            this.TedarikciAdi.DataPropertyName = "TedarikciAdi";
            this.TedarikciAdi.HeaderText = "Adı";
            this.TedarikciAdi.Name = "TedarikciAdi";
            this.TedarikciAdi.ReadOnly = true;
            this.TedarikciAdi.Width = 200;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Faks
            // 
            this.Faks.DataPropertyName = "Faks";
            this.Faks.HeaderText = "Faks";
            this.Faks.Name = "Faks";
            this.Faks.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "EMail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Width = 300;
            // 
            // IBAN
            // 
            this.IBAN.DataPropertyName = "IBAN";
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.ReadOnly = true;
            // 
            // BankaHesapNo
            // 
            this.BankaHesapNo.DataPropertyName = "BankaHesapNo";
            this.BankaHesapNo.HeaderText = "Banka Hesap No";
            this.BankaHesapNo.Name = "BankaHesapNo";
            this.BankaHesapNo.ReadOnly = true;
            // 
            // EklenmeTarihi
            // 
            this.EklenmeTarihi.DataPropertyName = "EklenmeTarihi";
            this.EklenmeTarihi.HeaderText = "Eklenme Tarihi";
            this.EklenmeTarihi.Name = "EklenmeTarihi";
            this.EklenmeTarihi.ReadOnly = true;
            // 
            // YurtIcimi
            // 
            this.YurtIcimi.DataPropertyName = "YurtIcimi";
            this.YurtIcimi.FalseValue = "0";
            this.YurtIcimi.HeaderText = "Yurt İçi Mi?";
            this.YurtIcimi.Name = "YurtIcimi";
            this.YurtIcimi.ReadOnly = true;
            this.YurtIcimi.TrueValue = "1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1201, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TedarikciTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 558);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Controls.Add(this.button1);
            this.Name = "TedarikciTanimla";
            this.Text = "Tedarikçiler";
            this.Load += new System.EventHandler(this.TedarikciTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faks;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaHesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EklenmeTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YurtIcimi;
        private System.Windows.Forms.Button button1;
    }
}