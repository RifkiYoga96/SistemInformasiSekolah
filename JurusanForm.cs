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
            dataGridView1.Columns["Code"].Width = 100;
        }

        private void SaveData()
        {
            string jurusanId = idJurusanTxt.Text;
            string namaJurusan = namaJurusanTxt.Text;
            string code = codeTxt.Text;
            if (namaJurusan == string.Empty && code == string.Empty)
            {
                MessageBox.Show("Nama Jurusan dan Code Wajib Diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (jurusanId == string.Empty)
            {
                if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusanDal.Insert(namaJurusan, code);
                    LoadData();
                }
            }
            else
            {
                if (MessageBox.Show("Save Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    jurusanDal.Update(Convert.ToInt32(jurusanId), namaJurusan, code);
                    LoadData();
                }
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
            codeTxt.Clear();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var jurusanId = dataGridView1.CurrentRow.Cells["JurusanId"].Value?.ToString();
            var jurusan = jurusanDal.GetData(Convert.ToInt32(jurusanId));
            if (jurusan == null) return;
            idJurusanTxt.Text = jurusanId;
            namaJurusanTxt.Text = jurusan.NamaJurusan;
            codeTxt.Text = jurusan.Code;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (idJurusanTxt.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                jurusanDal.Delete(int.Parse(idJurusanTxt.Text));
                LoadData();
                
            }
        }
    }
}
