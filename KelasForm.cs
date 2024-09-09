using SistemInformasiSekolah.Dal;
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
            dataGridView1.DataSource = kelasDal.ListData();
        }

        public void InitCombo1()
        {
            var jurusan = jurusanDal.ListData();
            if (!jurusan.Any()) return;
            List<JurusanModel> listJurusan = new List<JurusanModel>();
            foreach (var item in jurusan)
            {
                listJurusan.Add(new JurusanModel { JurusanId = item.JurusanId, NamaJurusan = item.NamaJurusan });
            }

            jurusanCombo.DataSource = listJurusan;
            jurusanCombo.DisplayMember = "NamaJurusan";
            jurusanCombo.ValueMember = "JurusanId";
        }

        public void InitCombo()
        {
            var jurusan = jurusanDal.ListData();
            if (!jurusan.Any()) return;
            List<string> listJurusan = new List<string>();
            foreach (var item in jurusan)
            {
                listJurusan.Add(item.NamaJurusan);
            }
            jurusanCombo.DataSource = listJurusan;
        }

        public void SaveData()
        {
            int kelasId = idKelasTxt.Text==string.Empty ? 0 : int.Parse(idKelasTxt.Text);
            string namaKelas = namaKelasTxt.Text;
            int tingkat = 0;
            if (radio10.Checked) tingkat = 10;
            if (radio11.Checked) tingkat = 11;
            if (radio12.Checked) tingkat = 12;
            string namaJurusan = jurusanCombo.SelectedItem.ToString() ?? string.Empty;

            string namaKelasJurusan = $"{namaKelas} {namaJurusan}";

            if(namaKelas == "" || tingkat == 0 || namaJurusan == "")
            {
                MessageBox.Show("Seluruh Data Wajib Diisi Kecuali KelasId","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var kelas = new KelasModel
            {
                KelasId = kelasId,
                NamaKelas = namaKelasJurusan,
                Tingkat = tingkat
            };
            if(MessageBox.Show("Input Data?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kelasDal.Insert(kelas);
                LoadData();
            }
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
