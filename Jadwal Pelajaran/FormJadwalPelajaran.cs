using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Jadwal_Pelajaran;
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
    public partial class FormJadwalPelajaran : Form
    {
        private readonly JadwalPelajaranDal jadwalPelajaranDal;
        private readonly MapelDal mapelDal;
        private readonly GuruDal guruDal;
        private readonly KelasDal kelasDal;
        private int jadwalPelajaranId;
        public FormJadwalPelajaran()
        {
            InitializeComponent();
            jadwalPelajaranDal = new JadwalPelajaranDal();
            mapelDal = new MapelDal();
            guruDal = new GuruDal();
            kelasDal = new KelasDal();
            InitCombo();
            LoadData();
            RegisterEvent();
            InitGrid();
        }
        private void InitCombo()
        {
            comboJenisJadwal.DataSource = new string[] { "--- Pilih Jenis Jadwal ---", "Normada", "Jurusan" };

            comboHari.DataSource = new string[] { "--- Pilih Hari---", "Senin", "Selasa", "Rabu", "Kamis", "Jum`at", "Sabtu" };

            mapelCombo.DataSource = mapelDal.ListData();
            mapelCombo.DisplayMember = "NamaMapel";
            mapelCombo.ValueMember = "MapelId";

            guruCombo.DataSource = guruDal.ListData(string.Empty, new { }).Select(x => new GuruModel { GuruId = x.GuruId, GuruName = x.GuruName }).ToList();
            guruCombo.DisplayMember = "GuruName";
            guruCombo.ValueMember = "GuruId";

            namaKelasTxt.Text = jadwalPelajaranDal.GetDataFirst(string.Empty, string.Empty)?.NamaKelas ?? string.Empty;
        }

        private void InitGrid()
        {
            //Grid Utama
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeight = 33;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 230;
        }
        private void SaveData()
        {
            var jadwal = new JadwalPelajaranModel()
            {
                JadwalPelajaranId = jadwalPelajaranId,
                KelasId = kelasDal.GetIdByName(namaKelasTxt.Text),
                Hari = comboHari.SelectedItem.ToString() ?? string.Empty,
                JenisJadwal = comboJenisJadwal.SelectedItem.ToString() ?? string.Empty,
                JamMulai = jamMulaiDT.Value.ToString("HH:mm"),
                JamSelesai = jamSelesaiDT.Value.ToString("HH:mm"),
                MapelId = (int)mapelCombo.SelectedValue,
                GuruId = (int)guruCombo.SelectedValue,
                Keterangan = txtKeterangan.Text
            };

            if (namaKelasTxt.Text == "" || comboJenisJadwal.SelectedIndex == 0 || comboHari.SelectedIndex == 0)
            {
                MessageBox.Show("Data Tidak Valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (jadwalPelajaranId == 0)
            {
                if (MessageBox.Show("Insert Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                jadwalPelajaranDal.Insert(jadwal);
                LoadData();
            }
            else
            {
                if (MessageBox.Show("Update Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                jadwalPelajaranDal.Insert(jadwal);
                LoadData();
            }
        }

        private void GetData(int JadwalPelajaranId)
        {
            var dataJadwal = jadwalPelajaranDal.GetData(JadwalPelajaranId);
            if (dataJadwal is null) return;
            jadwalPelajaranId = dataJadwal.JadwalPelajaranId;
           
            foreach (var x in comboJenisJadwal.Items)
                if (dataJadwal.JenisJadwal == (string)x)
                    comboJenisJadwal.SelectedItem = x;
            foreach (var x in comboHari.Items)
                if ((string)x == dataJadwal.Hari)
                    comboHari.SelectedItem = x;
            jamMulaiDT.Value = DateTime.ParseExact(dataJadwal.JamMulai, "HH:mm", null);
            jamSelesaiDT.Value = DateTime.ParseExact(dataJadwal.JamSelesai, "HH:mm", null);
            foreach (var x in mapelCombo.Items)
                if (x is MapelModel m)
                    if (m.MapelId == dataJadwal.MapelId)
                        mapelCombo.SelectedItem = x;
            foreach (var x in guruCombo.Items)
                if (x is GuruModel gm)
                    if (gm.GuruId == dataJadwal.GuruId)
                        guruCombo.SelectedItem = x;
            txtKeterangan.Text = dataJadwal.Keterangan;
        }
        private void LoadData()
        {
            string JenisJadwal = radioKhusus.Checked ? "Jurusan" : "Normada";
            int idKelas = jadwalPelajaranDal.GetDataFirst("WHERE NamaKelas=@NamaKelas", namaKelasTxt.Text)?.KelasId ?? 0;
            var listJadwal = jadwalPelajaranDal.ListData(idKelas, JenisJadwal) ?? new List<JadwalPelajaranModel>();
            dataGridView1.DataSource = listJadwal
                .Select(x => new
                {
                    Hari = x.Hari,
                    Waktu = $"{x.JamMulai}-{x.JamSelesai}",
                    Mapel = $"{x.NamaMapel}{x.Keterangan}",
                    Guru = x.GuruName,
                    JadwalPelajaranId = x.JadwalPelajaranId
                }).ToList();
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.CellPainting += MapelUmum_grid_CellPainting;
            dataGridView1.Paint += MapelUmum_grid_Paint;

        }

        private void MapelUmum_grid_Paint(object? sender, PaintEventArgs e)
        {
            int rowIndex = 0;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                // Dapatkan nilai awal dari baris saat ini untuk kolom "Hari"
                var currentHariValue = dataGridView1.Rows[rowIndex].Cells[0].Value?.ToString();

                // Hitung berapa banyak baris berturut-turut yang memiliki nilai yang sama
                int rowSpan = 1;

                for (int i = rowIndex + 1; i < dataGridView1.Rows.Count && i < rowIndex + 6; i++)  // Cek hingga 6 baris ke depan
                {
                    var nextHariValue = dataGridView1.Rows[i].Cells[0].Value?.ToString();
                    if (nextHariValue == currentHariValue)
                    {
                        rowSpan++;
                    }
                    else
                    {
                        break;  // Jika ada nilai yang berbeda, hentikan loop
                    }
                }

                if (rowSpan > 1)
                {
                    // Menggambar teks untuk sel yang digabungkan
                    var cellHeight = dataGridView1.GetRowDisplayRectangle(rowIndex, true).Height * rowSpan;
                    var cellBounds = new Rectangle(dataGridView1.GetCellDisplayRectangle(0, rowIndex, true).Location, new Size(dataGridView1.GetCellDisplayRectangle(0, rowIndex, true).Width, cellHeight));

                    // Menggambar cell yang digabungkan
                    e.Graphics.FillRectangle(new SolidBrush(dataGridView1.DefaultCellStyle.BackColor), cellBounds);
                    e.Graphics.DrawRectangle(Pens.LightGray, cellBounds);
                    e.Graphics.DrawString(currentHariValue, dataGridView1.DefaultCellStyle.Font, Brushes.Black, cellBounds);

                    // Lewati baris yang telah digabungkan
                    rowIndex += rowSpan;
                }
                else
                {
                    // Tidak ada penggabungan, lanjut ke baris berikutnya
                    rowIndex++;
                }
            }
        }

        private void MapelUmum_grid_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            // Cek apakah ini kolom "Hari" (misal, kolom ke-0)
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);  // Menggambar latar belakang

                // Menggambar teks sel
                var cellValue = e.Value?.ToString();
                if (cellValue != null)
                {
                    e.Graphics.DrawString(cellValue, e.CellStyle.Font, Brushes.Black, e.CellBounds);
                }

                e.Handled = true;  // Menandakan bahwa kita telah menggambar sel ini
            }
        }


        #region EVENT
        private void RegisterEvent()
        {
            btnKelas.Click += btnKelas_Click;
            btnSave.Click += btnSave_Click;

            namaKelasTxt.TextChanged += Changed;
            radioKhusus.CheckedChanged += Changed;
            radioUmum.CheckedChanged += Changed;

            dataGridView1.RowEnter += dataGridView1_RowEnter;

            btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void dataGridView1_RowEnter(object? sender, DataGridViewCellEventArgs e)
        {
            int JadwalPelajaranId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["JadwalPelajaranId"].Value);
            GetData(JadwalPelajaranId);
        }
        private void btnKelas_Click(object? sender, EventArgs e)
        {
            string namaKelas = namaKelasTxt.Text;
            FormKelasJadwal fkj = new FormKelasJadwal(namaKelas);
            if (fkj.ShowDialog() != DialogResult.OK) return;
            namaKelasTxt.Text = fkj.Kelas;
        }

        private void Changed(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            SaveData();
        }
        #endregion


        private void ClearForm()
        {
            comboHari.SelectedIndex = 0;
            jamMulaiDT.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            jamSelesaiDT.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            mapelCombo.SelectedIndex = 0;
            guruCombo.SelectedIndex = 0;
            txtKeterangan.Clear();
        }
    }
}
