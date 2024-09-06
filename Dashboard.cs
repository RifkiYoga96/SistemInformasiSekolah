using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemInformasiSekolah
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataIndukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }

        private void mapelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapelForm mf = new MapelForm();
            mf.MdiParent = this;
            mf.FormBorderStyle = FormBorderStyle.None;
            mf.Dock = DockStyle.Fill;
            mf.Show();
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JurusanForm jf = new JurusanForm();
            jf.MdiParent = this;
            jf.FormBorderStyle = FormBorderStyle.None;
            jf.Show();
        }
    }
}
