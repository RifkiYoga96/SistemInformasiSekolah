using SistemInformasiSekolah.Dal;
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
    public partial class JurusanForm : Form
    {
        private readonly JurusanDal jurusanDal;
        public JurusanForm()
        {
            InitializeComponent();
            jurusanDal = new JurusanDal();
            LoadData();
        }

        public void LoadData()
        {
            var data = jurusanDal.ListData();
            dataGridView1.DataSource = data;
            if (!data.Any()) return;
            dataGridView1.Columns["JurusanId"].Width = 150;
            dataGridView1.Columns["NamaJurusan"].Width = 150;
        }

        private void SaveData()
        {
            string jurusanId = idJurusanTxt.Text;
            string namaJurusan = namaJurusanTxt.Text;
            if (namaJurusan == string.Empty)
            {
                MessageBox.Show("Nama Mapel Wajib Diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(jurusanId == string.Empty)
            {
                if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusanDal.Insert(namaJurusan);
                    LoadData();
                }
            }
            else
            {
                if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusanDal.Update(Convert.ToInt32(jurusanId), namaJurusan);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idJurusanTxt.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                jurusanDal.Delete(int.Parse(idJurusanTxt.Text));
                LoadData();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            idJurusanTxt.Clear();
            namaJurusanTxt.Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            var idMapel = row.Cells["JurusanId"].Value?.ToString() ?? string.Empty;
            var NamaJurusan = row.Cells["NamaJurusan"].Value?.ToString() ?? string.Empty;

            idJurusanTxt.Text = idMapel;
            namaJurusanTxt.Text = NamaJurusan;
        }
    }
}
