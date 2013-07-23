﻿namespace TurStok.Tanimlamalar
{
    partial class SaklamaKosuluTanimla
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
            this.OlcuBirimiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaklamaKosulu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.OlcuBirimiID,
            this.SNo,
            this.SaklamaKosulu});
            this.grdOlcuBirimi.Location = new System.Drawing.Point(12, 12);
            this.grdOlcuBirimi.Name = "grdOlcuBirimi";
            this.grdOlcuBirimi.ReadOnly = true;
            this.grdOlcuBirimi.Size = new System.Drawing.Size(446, 478);
            this.grdOlcuBirimi.TabIndex = 10;
            // 
            // OlcuBirimiID
            // 
            this.OlcuBirimiID.DataPropertyName = "SaklamaKosuluID";
            this.OlcuBirimiID.HeaderText = "ID";
            this.OlcuBirimiID.Name = "OlcuBirimiID";
            this.OlcuBirimiID.ReadOnly = true;
            this.OlcuBirimiID.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "Sıra No";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            // 
            // SaklamaKosulu
            // 
            this.SaklamaKosulu.DataPropertyName = "SaklamaKosulu";
            this.SaklamaKosulu.HeaderText = "Adı";
            this.SaklamaKosulu.Name = "SaklamaKosulu";
            this.SaklamaKosulu.ReadOnly = true;
            this.SaklamaKosulu.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme Paneli";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 58);
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
            this.txtAdi.Location = new System.Drawing.Point(108, 29);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 23);
            this.txtAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saklama Koşulu";
            // 
            // SaklamaKosuluTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 605);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Controls.Add(this.groupBox1);
            this.Name = "SaklamaKosuluTanimla";
            this.Text = "Saklama Kosulu Tanimla";
            this.Load += new System.EventHandler(this.SaklamaKosuluTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOlcuBirimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaklamaKosulu;
    }
}