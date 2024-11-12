using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Kelas_Siswa;
using SistemInformasiSekolah.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemInformasiSekolah
{
    public partial class FormKelasSiswa : Form
    {
        private readonly KelasSiswaDal kelasSiswaDal;
        private readonly KelasSiswaDetailDal kelasSiswaDetailDal;
        private readonly SiswaDal siswaDal;
        private readonly GuruDal guruDal;
        private readonly KelasDal kelasDal;
        private BindingList<SiswaDto> allSiswaList = new BindingList<SiswaDto>();
        private BindingList<SiswaDto> kelasSiswaList = new BindingList<SiswaDto>();
        private BindingSource allSiswaBinding = new BindingSource();
        private BindingSource kelasSiswaBinding = new BindingSource();
        private bool Perubahan = false;
        private int kelasIdGlobal;
        public FormKelasSiswa()
        {
            InitializeComponent();

            kelasSiswaDal = new KelasSiswaDal();
            kelasSiswaDetailDal = new KelasSiswaDetailDal();
            siswaDal = new SiswaDal();
            guruDal = new GuruDal();
            kelasDal = new KelasDal();
            allSiswaBinding.DataSource = allSiswaList;
            kelasSiswaBinding.DataSource = kelasSiswaList;

            gridSiswa.DataSource = allSiswaBinding;
            gridKelasSiswa.DataSource = kelasSiswaBinding;
            gridKelasSiswa.ReadOnly = true;
            gridSiswa.ReadOnly = true;
            gridSiswa.AllowUserToAddRows = false;
            gridKelasSiswa.AllowUserToAddRows = false;

            InitCombo();
            RegisterEvent();
            InitGrid();
        }
        private void InitCombo()
        {
            var listKelas = new List<KelasModel>
            { 
                new KelasModel { KelasId= -1, NamaKelas = "---Pilih Kelas---" }
            };
            var kelas = kelasDal.ListData()
                .Select(x => new KelasModel{KelasId=x.KelasId,NamaKelas=x.NamaKelas}).ToList();
            listKelas.AddRange(kelas);
            kelasCombo.DataSource = listKelas;
            kelasCombo.DisplayMember = "NamaKelas";
            kelasCombo.ValueMember = "KelasId";

            var listGuru = new List<GuruModel>
            {
                new GuruModel {GuruId = -1, GuruName = "---Pilih Guru---"}
            };
            var guru = guruDal.ListData(string.Empty, new {})
                .Select(x => new GuruModel{GuruId=x.GuruId,GuruName=x.GuruName}).ToList();
            listGuru.AddRange(guru);
            waliKelasCombo.DataSource = listGuru;
            waliKelasCombo.DisplayMember = "GuruName";
            waliKelasCombo.ValueMember = "GuruId";
        }

        private void InitGrid()
        {
            //Grid All
            gridSiswa.EnableHeadersVisualStyles = false;

            gridSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridSiswa.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridSiswa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridSiswa.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            gridSiswa.ColumnHeadersHeight = 33;
            gridSiswa.RowTemplate.Height = 30;
            gridSiswa.Columns[0].Width = 70;
            gridSiswa.Columns[1].Width = 200;
            gridSiswa.Columns[0].HeaderText = "Id";
            gridSiswa.Columns[1].HeaderText = "Nama";

            //Grid Kelas-Siswa
            gridKelasSiswa.EnableHeadersVisualStyles = false;

            gridKelasSiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridKelasSiswa.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridKelasSiswa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridKelasSiswa.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            gridKelasSiswa.ColumnHeadersHeight = 33;
            gridKelasSiswa.RowTemplate.Height = 30;
            gridKelasSiswa.Columns[0].Width = 70;
            gridKelasSiswa.Columns[1].Width = 200;
            gridKelasSiswa.Columns[0].HeaderText = "Id";
            gridKelasSiswa.Columns[1].HeaderText = "Nama";
        }
        private void RegisterEvent()
        {
            btnSave.Click += BtnSave_Click;
            kelasCombo.SelectedIndexChanged += KelasCombo_SelectedIndexChanged;
            gridSiswa.CellDoubleClick += GridSiswa_CellDoubleClick;
            gridKelasSiswa.CellDoubleClick += GridKelasSiswa_CellDoubleClick;
            txtFilter.TextChanged += TxtFilter_TextChanged;
        }

        private void TxtFilter_TextChanged(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void GridKelasSiswa_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return;
            var selectData = kelasSiswaList[e.RowIndex];
            if (selectData.SiswaId == 0) return;
            allSiswaList.Add(selectData);
            kelasSiswaList.Remove(selectData);
            Perubahan = true;
        }

        private void GridSiswa_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var selectData = allSiswaList[e.RowIndex];
            if (selectData.SiswaId == 0) return;
            kelasSiswaList.Add(selectData);
            allSiswaList.Remove(selectData);
            Perubahan = true;
        }

        private void KelasCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (kelasCombo.SelectedIndex == -1) return;
            if (Perubahan)
            {
                if (MessageBox.Show("Simpan Perubahan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveData(kelasIdGlobal);
            }
            Perubahan = false;
            LoadData();
            kelasIdGlobal = (int)kelasCombo.SelectedValue;
        }
        private void LoadData()
        {
            if (kelasCombo.SelectedIndex == -1) return;
            int kelasId = (int)kelasCombo.SelectedValue;
            var kelasSiswa = kelasSiswaDal.GetData(kelasId);
            string filter = txtFilter.Text;
            if(kelasSiswa is null)
            {
                ClearFrom();
            }
            txtTahunAjaran.Text = kelasSiswa?.TahunAjaran ?? string.Empty;
            waliKelasCombo.SelectedValue = kelasSiswa?.WaliKelasId ?? -1;
            var allSiswa = siswaDal.ListData(filter)?.ToList() ?? new();
            var siswaInKelas = kelasSiswaDetailDal.ListData()?.ToList() ?? new();
            var siswaIdInKelas = siswaInKelas.Select(x => x.SiswaId)?.ToList() ?? new();

            allSiswa.RemoveAll(x => siswaIdInKelas.Contains(x.SiswaId));
            allSiswaList.Clear();

            var allSiswaListTemp = allSiswa.Select(x => new SiswaDto(x.SiswaId,x.NamaLengkap))?.ToList() ?? new();
            foreach(var item in allSiswaListTemp)
                allSiswaList.Add(item);

            kelasSiswaList.Clear();
            var kelasSiswaDetail = kelasSiswaDetailDal.ListData(kelasId);
            var kelasSiswaListTemp = kelasSiswaDetail.Select(x => new SiswaDto(x.SiswaId, x.NamaLengkap))?.ToList() ?? new();
            foreach (var item in kelasSiswaListTemp)
                kelasSiswaList.Add(item);
        }
        private void ClearFrom()
        {
            txtTahunAjaran.Clear();
            waliKelasCombo.SelectedIndex = -1;
            allSiswaList.Clear();
            kelasSiswaList.Clear();
           
        }
/*        private void ListKelasTersedia()
        {
            var allSiswa = siswaDal.ListData()?.ToList() ?? new List<SiswaModel>();
            var siswaInKelas = kelasSiswaDetailDal.ListData()?.ToList() ?? new List<KelasSiswaDetailModel>();
            var siswaIdInKelas = siswaInKelas.Select(x => x.SiswaId).ToList() ?? new List<int>();

            allSiswa.RemoveAll(x => siswaIdInKelas.Contains(x.SiswaId));

            allSiswaList.Clear();
            var listSiswaTemp = allSiswa.Select(x => new SiswaDto(x.SiswaId,x.NamaLengkap))?.ToList() ?? new List<SiswaDto>();
            foreach (var item in listSiswaTemp) allSiswaList.Add(item);
            gridSiswa.Refresh();
        }*/
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveData(kelasIdGlobal);
        }
        private void SaveData(int kelasId)
        {
           
            int waliKelasId = waliKelasCombo.SelectedIndex < 0 ? -1 : (int)waliKelasCombo.SelectedValue;
            string tahunAjaran = txtTahunAjaran.Text;
            if (kelasId < 0 || waliKelasId < 0 || tahunAjaran == "")
            {
                MessageBox.Show("Data Tidak Valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Input Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var cekKelasSiswa = kelasSiswaDal.GetData(kelasId);
            if (cekKelasSiswa is null)
            {
                var kelasSiswa = new KelasSiswaModel()
                {
                    KelasId = kelasId,
                    TahunAjaran = tahunAjaran,
                    WaliKelasId = waliKelasId,
                };
                //kelasSiswaDal.Insert(kelasSiswa);
            }
            kelasSiswaDetailDal.Delete(kelasId);
            foreach (var item in kelasSiswaList)
            {
                var kelasSiswaDetail = new KelasSiswaDetailModel()
                {
                    KelasId = kelasId,
                    SiswaId = item.SiswaId
                };
                kelasSiswaDetailDal.Insert(kelasSiswaDetail);
            }
            LoadData();
            Perubahan = false;
        }
    }
}

public class SiswaDto
{
    public SiswaDto()
    {
    }
    public SiswaDto(int id, string name) => (SiswaId, SiswaName) = (id, name);
    public int SiswaId { get; set; }
    public string SiswaName { get; set; }
}