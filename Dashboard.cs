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

        private void kelasSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKelasSiswa kelasSiswa = new FormKelasSiswa();
            BukaForm(kelasSiswa);
        }

        private void mapelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BukaForm(new MapelForm());
        }

        private void jurusanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BukaForm(new JurusanForm());
        }

        private void kelasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BukaForm(new KelasForm());
        }

        private void guruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BukaForm(new FormGuru());
        }

        private void jadwalPelajaranToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BukaForm(new FormJadwalPelajaran());
        }
    }
}
