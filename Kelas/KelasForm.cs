using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Kesiswaan.Dal;
using SistemInformasiSekolah.Model;
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
    public partial class KelasForm : Form
    {
        private readonly SiswaDal siswaDal;
        private readonly JurusanDal jurusanDal;
        private readonly KelasDal kelasDal;
        public KelasForm()
        {
            InitializeComponent();
            siswaDal = new SiswaDal();
            jurusanDal = new JurusanDal();
            kelasDal = new KelasDal();
            InitCombo();
            LoadData();
        }

        public void LoadData()
        {
            var listkelas = kelasDal.ListData();
            dataGridView1.DataSource = listkelas.
                Select(x => new
                {
                    KelasId = x.KelasId,
                    Name = x.NamaKelas
                }).ToList();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                dataGridView1.Columns["KelasId"].Width = 100;
                dataGridView1.Columns["Name"].Width = 150;
                dataGridView1.RowTemplate.Height = 25;
                dataGridView1.ColumnHeadersHeight = 25;
            }
        }

        public void InitCombo()
        {
            var jurusan = jurusanDal.ListData();
            if (!jurusan.Any()) return;
            jurusanCombo.DataSource = jurusan;
            jurusanCombo.DisplayMember = "NamaJurusan";
            jurusanCombo.ValueMember = "JurusanId";
        }

        public void SaveData()
        {
            int kelasId = idKelasTxt.Text == string.Empty ? 0 : int.Parse(idKelasTxt.Text);
            int tingkat = radio10.Checked ? 10 : radio11.Checked ? 11 : radio12.Checked ? 12 : 0;
            string flag = flagTxt.Text;

            if (tingkat == 0 || flag == string.Empty)
            {
                MessageBox.Show("Seluruh Data Wajib Diisi Kecuali KelasId", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kelas = new KelasModel
            {
                KelasId = kelasId,
                NamaKelas = namaKelasTxt.Text,
                Tingkat = tingkat,
                JurusanId = Convert.ToInt32(jurusanCombo.SelectedValue),
                Flag = flag
            };
            if (idKelasTxt.Text == string.Empty)
            {
                if (MessageBox.Show("Input Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                kelasDal.Insert(kelas);
                LoadData();
            }
            else
            {
                if (MessageBox.Show("Update Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                kelasDal.Update(kelas);
                LoadData();
            }
        }

        private void SetKelasName()
        {
            int tingkat = radio10.Checked ? 10 : radio11.Checked ? 11 : 12;
            var jurusanId = Convert.ToInt16(((JurusanModel)jurusanCombo.SelectedItem).JurusanId);
            var jurusan = jurusanDal.GetData(jurusanId) ?? new JurusanModel { Code = "X"};
            string jurusanCode = jurusan.Code;
            string flag = flagTxt.Text;

            namaKelasTxt.Text = $"{tingkat.ToString()} {jurusanCode}-{flag}";
        }
        public void GetData()
        {
            string kelasId = dataGridView1.CurrentRow.Cells["KelasId"].Value.ToString() ?? string.Empty;
            var kelas = kelasDal.GetData(Convert.ToInt32(kelasId));
            if (kelas is null) return;
            idKelasTxt.Text = kelasId;
            //namaKelasTxt.Text = kelas.NamaKelas;
            if (kelas.Tingkat == 10) radio10.Checked = true;
            if (kelas.Tingkat == 11) radio11.Checked = true;
            if (kelas.Tingkat == 12) radio12.Checked = true;
            foreach (var item in jurusanCombo.ValueMember)
                if (kelas.JurusanId == (int)item)
                    jurusanCombo.SelectedValue = item;
            flagTxt.Text = kelas.Flag;
        }

        public void Delete()
        {
            string kelasId = idKelasTxt.Text;
            if (kelasId == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            kelasDal.Delete(int.Parse(kelasId));
            LoadData();
            ClearInput();
        }

        public void ClearInput()
        {
            idKelasTxt.Clear();
            radio10.Checked = false;
            radio11.Checked = false;
            radio12.Checked = false;
            jurusanCombo.SelectedIndex = 0;
            flagTxt.Clear();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void radio10_CheckedChanged(object sender, EventArgs e)
        {
            SetKelasName();
        }

        private void radio11_CheckedChanged(object sender, EventArgs e)
        {
            SetKelasName();
        }

        private void radio12_CheckedChanged(object sender, EventArgs e)
        {
            SetKelasName();
        }

        private void jurusanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetKelasName();
        }

        private void flagTxt_TextChanged(object sender, EventArgs e)
        {
            SetKelasName();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int kelasId = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var kelas = kelasDal.GetData(kelasId);
            if (kelas is null)
            {
                ClearInput();
                return;
            }

            idKelasTxt.Text = kelas.KelasId.ToString();
            namaKelasTxt.Text = kelas.NamaKelas;
            if (kelas.Tingkat == 10) radio10.Checked = true;
            if (kelas.Tingkat == 11) radio11.Checked = true;
            if (kelas.Tingkat == 12) radio12.Checked = true;
            foreach (var item in jurusanCombo.ValueMember)
                if (kelas.JurusanId == (int)item)
                    jurusanCombo.SelectedValue = item;
            flagTxt.Text = kelas.Flag;
        }
    }

}
