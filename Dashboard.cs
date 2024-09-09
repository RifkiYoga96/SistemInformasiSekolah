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
        private void BukaForm(Form form)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void dataIndukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            BukaForm(f1);
        }

        private void mapelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapelForm mf = new MapelForm();
            BukaForm(mf);
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JurusanForm jf = new JurusanForm();
            BukaForm(jf);
        }

        private void kelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KelasForm kf = new KelasForm();
            BukaForm(kf);
        }
    }
}
