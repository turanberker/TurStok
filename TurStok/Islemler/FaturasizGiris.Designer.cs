namespace TurStok.Islemler
{
    partial class FaturasizGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunID = new System.Windows.Forms.ComboBox();
            this.cmbDepoID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarkaID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTedarikciID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBitTar = new System.Windows.Forms.MaskedTextBox();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOlcuBirimi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saklanacağı Yer";
            // 
            // cmbUrunID
            // 
            this.cmbUrunID.FormattingEnabled = true;
            this.cmbUrunID.Location = new System.Drawing.Point(163, 8);
            this.cmbUrunID.Name = "cmbUrunID";
            this.cmbUrunID.Size = new System.Drawing.Size(222, 21);
            this.cmbUrunID.TabIndex = 8;
            this.cmbUrunID.SelectedIndexChanged += new System.EventHandler(this.cmbUrunID_SelectedIndexChanged);
            // 
            // cmbDepoID
            // 
            this.cmbDepoID.FormattingEnabled = true;
            this.cmbDepoID.Location = new System.Drawing.Point(163, 34);
            this.cmbDepoID.Name = "cmbDepoID";
            this.cmbDepoID.Size = new System.Drawing.Size(222, 21);
            this.cmbDepoID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Markası";
            // 
            // cmbMarkaID
            // 
            this.cmbMarkaID.FormattingEnabled = true;
            this.cmbMarkaID.Location = new System.Drawing.Point(163, 61);
            this.cmbMarkaID.Name = "cmbMarkaID";
            this.cmbMarkaID.Size = new System.Drawing.Size(222, 21);
            this.cmbMarkaID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tedarikçisi";
            // 
            // cmbTedarikciID
            // 
            this.cmbTedarikciID.FormattingEnabled = true;
            this.cmbTedarikciID.Location = new System.Drawing.Point(163, 88);
            this.cmbTedarikciID.Name = "cmbTedarikciID";
            this.cmbTedarikciID.Size = new System.Drawing.Size(222, 21);
            this.cmbTedarikciID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kalan Miktar";
            // 
            // txtBitTar
            // 
            this.txtBitTar.Location = new System.Drawing.Point(163, 142);
            this.txtBitTar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBitTar.Mask = "00.00.0000";
            this.txtBitTar.Name = "txtBitTar";
            this.txtBitTar.Size = new System.Drawing.Size(94, 20);
            this.txtBitTar.TabIndex = 10;
            // 
            // txtKalan
            // 
            this.txtKalan.Location = new System.Drawing.Point(163, 115);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.Size = new System.Drawing.Size(94, 20);
            this.txtKalan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Son Kullanma Tarihi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(317, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOlcuBirimi
            // 
            this.lblOlcuBirimi.AutoSize = true;
            this.lblOlcuBirimi.Location = new System.Drawing.Point(264, 121);
            this.lblOlcuBirimi.Name = "lblOlcuBirimi";
            this.lblOlcuBirimi.Size = new System.Drawing.Size(0, 13);
            this.lblOlcuBirimi.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(36, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FaturasizGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOlcuBirimi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.txtBitTar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTedarikciID);
            this.Controls.Add(this.cmbMarkaID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepoID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUrunID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FaturasizGiris";
            this.Text = "Faturasız Giriş";
            this.Load += new System.EventHandler(this.FaturasizGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunID;
        private System.Windows.Forms.ComboBox cmbDepoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarkaID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTedarikciID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtBitTar;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOlcuBirimi;
        private System.Windows.Forms.Button button2;
    }
}