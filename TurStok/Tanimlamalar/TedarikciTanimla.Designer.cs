﻿namespace TurStok.Tanimlamalar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkYurtIci = new System.Windows.Forms.CheckBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFaks = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.grdOlcuBirimi.Location = new System.Drawing.Point(12, 3);
            this.grdOlcuBirimi.Name = "grdOlcuBirimi";
            this.grdOlcuBirimi.ReadOnly = true;
            this.grdOlcuBirimi.Size = new System.Drawing.Size(1295, 478);
            this.grdOlcuBirimi.TabIndex = 4;
            this.grdOlcuBirimi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOlcuBirimi_CellContentClick);
            this.grdOlcuBirimi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOlcuBirimi_CellDoubleClick);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkYurtIci);
            this.groupBox1.Controls.Add(this.txtHesapNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIBAN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFaks);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1295, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkYurtIci
            // 
            this.chkYurtIci.AutoSize = true;
            this.chkYurtIci.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.chkYurtIci.Location = new System.Drawing.Point(1156, 63);
            this.chkYurtIci.Name = "chkYurtIci";
            this.chkYurtIci.Size = new System.Drawing.Size(90, 20);
            this.chkYurtIci.TabIndex = 17;
            this.chkYurtIci.Text = "Yurt İçi Mi?";
            this.chkYurtIci.UseVisualStyleBackColor = true;
            this.chkYurtIci.CheckedChanged += new System.EventHandler(this.chkYurtIci_CheckedChanged);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHesapNo.Location = new System.Drawing.Point(982, 63);
            this.txtHesapNo.MaxLength = 100;
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(148, 23);
            this.txtHesapNo.TabIndex = 16;
            this.txtHesapNo.TextChanged += new System.EventHandler(this.txtHesapNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(979, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Banka Hesap No";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIBAN
            // 
            this.txtIBAN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBAN.Location = new System.Drawing.Point(828, 63);
            this.txtIBAN.MaxLength = 100;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(148, 23);
            this.txtIBAN.TabIndex = 14;
            this.txtIBAN.TextChanged += new System.EventHandler(this.txtIBAN_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(825, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "IBAN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtEMail
            // 
            this.txtEMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMail.Location = new System.Drawing.Point(472, 63);
            this.txtEMail.MaxLength = 100;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(148, 23);
            this.txtEMail.TabIndex = 12;
            this.txtEMail.TextChanged += new System.EventHandler(this.txtEMail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Mail";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFaks
            // 
            this.txtFaks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaks.Location = new System.Drawing.Point(319, 63);
            this.txtFaks.Mask = "99(999) 000 00 00";
            this.txtFaks.Name = "txtFaks";
            this.txtFaks.Size = new System.Drawing.Size(147, 23);
            this.txtFaks.TabIndex = 10;
            this.txtFaks.Text = "90";
            this.txtFaks.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtFaks_MaskInputRejected);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(165, 63);
            this.txtTelefon.Mask = "99(999) 000 00 00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(147, 23);
            this.txtTelefon.TabIndex = 9;
            this.txtTelefon.Text = "90";
            this.txtTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefon_MaskInputRejected);
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(626, 63);
            this.txtAdres.MaxLength = 200;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(196, 52);
            this.txtAdres.TabIndex = 8;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Faks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdi.Location = new System.Drawing.Point(10, 63);
            this.txtAdi.MaxLength = 100;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(148, 23);
            this.txtAdi.TabIndex = 1;
            this.txtAdi.TextChanged += new System.EventHandler(this.txtAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TedarikciTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 631);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Controls.Add(this.groupBox1);
            this.Name = "TedarikciTanimla";
            this.Text = "Tedarikçiler";
            this.Load += new System.EventHandler(this.TedarikciTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtFaks;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkYurtIci;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEMail;
    }
}