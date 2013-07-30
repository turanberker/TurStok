namespace TurStok.Tanimlamalar
{
    partial class KategoriTanimla
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OlcuBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiadVarmi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.ID,
            this.SNo,
            this.OlcuBirimi,
            this.MiadVarmi});
            this.grdOlcuBirimi.Location = new System.Drawing.Point(12, 12);
            this.grdOlcuBirimi.Name = "grdOlcuBirimi";
            this.grdOlcuBirimi.ReadOnly = true;
            this.grdOlcuBirimi.Size = new System.Drawing.Size(445, 478);
            this.grdOlcuBirimi.TabIndex = 4;
            this.grdOlcuBirimi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOlcuBirimi_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "KategoriID";
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
            // OlcuBirimi
            // 
            this.OlcuBirimi.DataPropertyName = "KategoriAdi";
            this.OlcuBirimi.HeaderText = "Adı";
            this.OlcuBirimi.Name = "OlcuBirimi";
            this.OlcuBirimi.ReadOnly = true;
            this.OlcuBirimi.Width = 200;
            // 
            // MiadVarmi
            // 
            this.MiadVarmi.DataPropertyName = "MiadVarmi";
            this.MiadVarmi.FalseValue = "False";
            this.MiadVarmi.HeaderText = "Miadı Varmi";
            this.MiadVarmi.Name = "MiadVarmi";
            this.MiadVarmi.ReadOnly = true;
            this.MiadVarmi.TrueValue = "True";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(349, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KategoriTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdOlcuBirimi);
            this.Name = "KategoriTanimla";
            this.Text = "Kategori Tanımla";
            this.Load += new System.EventHandler(this.KategoriTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOlcuBirimi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView grdOlcuBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlcuBirimi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MiadVarmi;
        private System.Windows.Forms.Button button1;
    }
}