using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TurStok.Islemler;
using TurStok.Tanimlamalar;

namespace TurStok
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public DataTable StokDataTable;
        public Form Varmi(string formname)
        {
            Form frm = null;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == formname)
                {
                    frm = item;
                    break;
                }
            }
            return frm;
        }

        private void bağlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            splitter1.Width = label4.Width + 10;
            toolStripLabel2.Text = "Giriş Yapın - " + DateTime.Today.ToString("dd.MM.yyyy");
            groupBox1.Left = (this.Width - splitter1.Width) / 2 - groupBox1.Width / 2;
            groupBox1.Top = this.Height / 2 - groupBox1.Height / 2;
            grd2ay.Height = grd1ay.Height = grdBitenler.Height = (splitter1.Height - 4 * label5.Height) / 3;
            grd2ay.Top = label3.Top + label3.Height;
            grd2ay.Width = splitter1.Width;
            grd2ay.Left = grd1ay.Left = grdBitenler.Left = splitter1.Left;
            label3.Left = label4.Left = label5.Left = splitter1.Left;
            grd1ay.Width = grdBitenler.Width = splitter1.Width;
            label4.Top = label3.Top + label3.Height + grd2ay.Height;
            grd1ay.Top = label4.Top + label4.Height;
            label5.Top = grd1ay.Top + grd1ay.Height;
            grdBitenler.Top = label5.Top + label5.Height;
            grd1ay.AllowUserToAddRows = grd2ay.AllowUserToAddRows = grdBitenler.AllowUserToAddRows = false;
            grd1ay.AllowUserToDeleteRows = grd2ay.AllowUserToDeleteRows = grdBitenler.AllowUserToDeleteRows = false;

        }

        private void ölçüBirimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("OlcuBirimiTanimla");
            if (f == null)
            {
                f = new OlcuBirimiTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "admin")
                {

                    tanımlamalarToolStripMenuItem.Enabled = true;
                    islemlerToolStripMenuItem.Enabled = true;
                    cikisToolStripMenuItem.Enabled = true;
                    bağlanToolStripMenuItem.Enabled = false;
                    toolStripLabel2.Text = "Admin - " + DateTime.Today.ToString("dd.MM.yyyy");
                    toolStripButton1.Enabled = true;

                    groupBox1.Visible = false;
                    GridleriDoldur();

                }
                else if (textBox1.Text == "User" && textBox2.Text == "user")
                {

                    islemlerToolStripMenuItem.Enabled = true;
                    cikisToolStripMenuItem.Enabled = true;
                    bağlanToolStripMenuItem.Enabled = false;
                    toolStripLabel2.Text = "User - " + DateTime.Today.ToString("dd.MM.yyyy");
                    toolStripButton1.Enabled = true;
                    groupBox1.Visible = false;
                    GridleriDoldur();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı-Şifre Uyumsuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = textBox2.Text = "";
            }
            catch (Exception exp)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = new StackFrame();
                new Helper.ExceptionLogger().ThrowExp(exp, this as Form, sf.GetMethod().Name);
            }
        }
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            toolStrip1.Text = DateTime.Today.ToString("dd.MM.yyyy");
            tanımlamalarToolStripMenuItem.Enabled = false;
            islemlerToolStripMenuItem.Enabled = false;
            cikisToolStripMenuItem.Enabled = false;
            bağlanToolStripMenuItem.Enabled = true;
            groupBox1.Visible = true;
            toolStripButton1.Enabled = false;
            toolStripLabel2.Text = "Giriş Yapın - " + DateTime.Today.ToString("dd.MM.yyyy");
            using (DataView dw = new DataView(StokDataTable))
            {
                dw.RowFilter = "MiadVarmi = 'True'";
                using (DataView bos = new DataView(dw.ToTable()))
                {
                    bos.RowFilter = "StokID ='0'";
                    grd1ay.DataSource = bos.ToTable();
                    grd2ay.DataSource = bos.ToTable();
                    grdBitenler.DataSource = bos.ToTable();
                }
            }

        }
        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("MarkaTanimla");
            if (f == null)
            {
                f = new MarkaTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }

        }
        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("Faturalar");
            if (f == null)
            {
                f = new Faturalar(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("KategoriTanimla");
            if (f == null)
            {
                f = new KategoriTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void depolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("DepoTanimla");
            if (f == null)
            {
                f = new DepoTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void paraBirimiTanimlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("ParaBirimiTanimla");
            if (f == null)
            {
                f = new ParaBirimiTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void saklamaKoşullarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("SaklamaKosuluTanimla");
            if (f == null)
            {
                f = new SaklamaKosuluTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void tedarikçilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("TedarikciTanimla");
            if (f == null)
            {
                f = new TedarikciTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void ödemeŞekilleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("OdemeSekliTanimla");
            if (f == null)
            {
                f = new OdemeSekliTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("UrunTanimla");
            if (f == null)
            {
                f = new UrunTanimla(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = Varmi("Stok");
            if (f == null)
            {
                f = new Stok(this as Main, StokDataTable);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("StokGirisi");
            if (f == null)
            {
                f = new StokGirisi(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        public void GridleriDoldur()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            Helper.GridDoldurucular arac = new Helper.GridDoldurucular();
            StokDataTable = arac.StoguGetir();

            using (DataView dw = new DataView(StokDataTable))
            {
                dw.RowFilter = "MiadVarmi = 'True'";
                using (DataView dw1ay = new DataView(dw.ToTable()))
                {
                    dw1ay.RowFilter = String.Format("SonKullanmaTarihi < '{0}'", DateTime.Today.AddMonths(1));
                    grd1ay.DataSource = dw1ay.ToTable();
                }
                using (DataView dw2ay = new DataView(dw.ToTable()))
                {
                    dw2ay.RowFilter = String.Format("SonKullanmaTarihi > '{0}' and SonKullanmaTarihi <'{1}' ", DateTime.Today.AddMonths(1), DateTime.Today.AddMonths(2));
                    grd2ay.DataSource = dw2ay.ToTable();
                }
            }
            using (DataView dwbitenler = new DataView(StokDataTable))
            {
                dwbitenler.RowFilter = "AzamiMiktar > KalanMiktar";
                grdBitenler.DataSource = dwbitenler.ToTable();
            }
        }

        private void grd1ay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //      string ID = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            DataRow secilen = StokDataTable.Rows.Cast<DataRow>().Where(x => x["StokID"].ToString() == grd1ay.Rows[e.RowIndex].Cells["StokID1ay"].Value.ToString()).FirstOrDefault();
            Form f = Varmi("StokDetay");
            if (f != null)
            {
                f.Close();
            }
            f = new StokDetay(this as Main, secilen);
            f.MdiParent = this;
            f.Show();
        }

        private void siparişLİstesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("IhtiyacListesi");
            if (f == null)
            {
                f = new İhtiyacListesi(this as Main);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("Hakkinda");
            if (f == null)
            {
                f = new Hakkinda();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }

        private void grd2ay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //   string ID = (sender as DataGridView).Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn14"].Value.ToString();
            DataRow secilen = StokDataTable.Rows.Cast<DataRow>().Where(x => x["StokID"].ToString() == grd2ay.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn14"].Value.ToString()).FirstOrDefault();
            Form f = Varmi("StokDetay");
            if (f != null)
            {
                f.Close();
            }
            f = new StokDetay(this as Main, secilen);
            f.MdiParent = this;
            f.Show();
        }

        private void grdBitenler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string ID = (sender as DataGridView).Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            DataRow secilen = StokDataTable.Rows.Cast<DataRow>().Where(x => x["StokID"].ToString() == grdBitenler.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString()).FirstOrDefault();
            Form f = Varmi("StokDetay");
            if (f != null)
            {
                f.Close();
            }
            f = new StokDetay(this as Main, secilen);
            f.MdiParent = this;
            f.Show();
        }

    }
}
