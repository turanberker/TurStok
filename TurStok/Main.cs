using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurStok.Tanimlamalar;

namespace TurStok
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Form Varmi(string frmtext)
        {
            Form frm = null;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == frmtext)
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
            toolStripLabel2.Text = "Giriş Yapın - " + DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void ölçüBirimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("Ölçü Birimi Tanımla");
            if (f == null)
            {
                f = new OlcuBirimiTanimla();
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
            if (textBox1.Text == "Admin" && textBox2.Text == "admin")
            {
               
                tanımlamalarToolStripMenuItem.Enabled = true;
                islemlerToolStripMenuItem.Enabled = true;
                cikisToolStripMenuItem.Enabled = true;
                bağlanToolStripMenuItem.Enabled = false;
                toolStripLabel2 .Text = "Admin - " + DateTime.Today.ToString("dd.MM.yyyy");
                
                groupBox1.Visible = false;
                

            }
            else if (textBox1.Text == "User" && textBox2.Text == "user")
            {
               
                islemlerToolStripMenuItem.Enabled = true;
                cikisToolStripMenuItem.Enabled = true;
                bağlanToolStripMenuItem.Enabled = false;
                toolStripLabel2.Text = "User - " + DateTime.Today.ToString("dd.MM.yyyy");
                groupBox1.Visible = false;                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı-Şifre Uyumsuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Text = textBox2.Text = "";
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
            toolStripLabel2.Text = "Giriş Yapın - " + DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Varmi("Marka Tanimla");
            if (f == null)
            {
                f = new MarkaTanimla();
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
                f = new Faturalar();
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
            Form f = Varmi("Kategori Tanımla");
            if (f == null)
            {
                f = new KategoriTanimla();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.BringToFront();
                this.ActivateMdiChild(f);
            }
        }
    }
}
