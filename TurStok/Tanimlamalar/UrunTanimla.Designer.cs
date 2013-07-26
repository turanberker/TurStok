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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdOlcuBirimi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbOlcuBirimi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSaklamaKosuluID = new System.Windows.Forms.ComboBox();
            this.txtAzami = new System.Windows.Forms.TextBox();
            this.cmbKategoriID = new System.Windows.Forms.ComboBox();
            this.TedarikciID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(674, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saklama Kosulu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azami Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategorisi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunAdi.Location = new System.Drawing.Point(10, 63);
            this.txtUrunAdi.MaxLength = 50;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(148, 23);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // grdOlcuBirimi
            // 
            this.grdOlcuBirimi.AllowUserToAddRows = false;
            this.grdOlcuBirimi.AllowUserToDeleteRows = false;
            this.grdOlcuBirimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOlcuBirimi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TedarikciID,
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOlcuBirimi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSaklamaKosuluID);
            this.groupBox1.Controls.Add(this.txtAzami);
            this.groupBox1.Controls.Add(this.cmbKategoriID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbOlcuBirimi
            // 
            this.cmbOlcuBirimi.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbOlcuBirimi.FormattingEnabled = true;
            this.cmbOlcuBirimi.Location = new System.Drawing.Point(487, 63);
            this.cmbOlcuBirimi.Name = "cmbOlcuBirimi";
            this.cmbOlcuBirimi.Size = new System.Drawing.Size(184, 24);
            this.cmbOlcuBirimi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ölçü Birimi";
            // 
            // cmbSaklamaKosuluID
            // 
            this.cmbSaklamaKosuluID.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbSaklamaKosuluID.FormattingEnabled = true;
            this.cmbSaklamaKosuluID.Location = new System.Drawing.Point(677, 62);
            this.cmbSaklamaKosuluID.Name = "cmbSaklamaKosuluID";
            this.cmbSaklamaKosuluID.Size = new System.Drawing.Size(184, 24);
            this.cmbSaklamaKosuluID.TabIndex = 20;
            this.cmbSaklamaKosuluID.SelectedIndexChanged += new System.EventHandler(this.cmbSaklamaKosuluID_SelectedIndexChanged);
            // 
            // txtAzami
            // 
            this.txtAzami.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtAzami.Location = new System.Drawing.Point(356, 63);
            this.txtAzami.Name = "txtAzami";
            this.txtAzami.Size = new System.Drawing.Size(125, 23);
            this.txtAzami.TabIndex = 19;
            // 
            // cmbKategoriID
            // 
            this.cmbKategoriID.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbKategoriID.FormattingEnabled = true;
            this.cmbKategoriID.Location = new System.Drawing.Point(165, 63);
            this.cmbKategoriID.Name = "cmbKategoriID";
            this.cmbKategoriID.Size = new System.Drawing.Size(184, 24);
            this.cmbKategoriID.TabIndex = 18;
            // 
            // TedarikciID
            // 
            this.TedarikciID.DataPropertyName = "UrunID";
            this.TedarikciID.HeaderText = "ID";
            this.TedarikciID.Name = "TedarikciID";
            this.TedarikciID.ReadOnly = true;
            this.TedarikciID.Visible = false;
            this.TedarikciID.Width = 200;
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
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunTanimla";
            this.Text = "Urun Tanımla";
            this.Load += new System.EventHandler(this.UrunTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdOlcuBirimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSaklamaKosuluID;
        private System.Windows.Forms.TextBox txtAzami;
        private System.Windows.Forms.ComboBox cmbKategoriID;
        private System.Windows.Forms.ComboBox cmbOlcuBirimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TedarikciID;
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