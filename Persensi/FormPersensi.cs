using SistemInformasiSekolah.Kelas_Siswa;
using SistemInformasiSekolah.Model;
using SistemInformasiSekolah.Persensi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemInformasiSekolah
{
    public partial class FormPersensi : Form
    {
        private readonly PersensiDal persensiDal;
        private readonly PersensiDetailDal persensiDetailDal;
        private readonly Dal.KelasDal kelasDal;
        private readonly Dal.MapelDal mapelDal;
        private readonly Dal.GuruDal guruDal;
        private readonly KelasSiswaDetailDal ksdDal;
        private BindingSource bindingSource = new();
        private BindingList<PersensiDto> listPersensi = new();

        private bool LoadDataAwal = true;
        private bool Perubahan = false;
        private DateTime TglGlobal;
        private string JamGlobal;
        private int KelasIdGlobal;
        private int MapelIdGlobal;
        private int GuruIdGlobal;

        private int persensiIdGlobal = 0;

        
        public FormPersensi()
        {
            InitializeComponent();
            persensiDal = new PersensiDal();
            persensiDetailDal = new PersensiDetailDal();
            kelasDal = new Dal.KelasDal();
            mapelDal = new Dal.MapelDal();
            guruDal = new Dal.GuruDal();
            ksdDal = new KelasSiswaDetailDal();
            bindingSource.DataSource = listPersensi;
            InitComponen();
            RegisterEvent();
            dataGridView1.AllowUserToAddRows = false;
            SettingGrid();
            dataGridView1.DataSource = bindingSource;
        }

        private void SettingGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
            btnListSiswa.Click += BtnListSiswa_Click1;
            btnSave.Click += BtnSave_Click;
        }



        private void BtnListSiswa_Click1(object? sender, EventArgs e)
        {
            //masih Bug
            //ValidasiInput();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            SaveData();
        }

        private void DataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                for (int i = 2; i <= 5; i++)
                    if (i != e.ColumnIndex)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[i].Value = false;
                        UpdateTotalPersensi();
                    }    
        }

        private void UpdateTotalPersensi()
        {
            int Hadir = 0;
            int S = 0;
            int I = 0;
            int A = 0;
            foreach(var item in listPersensi)
            {
                if (item.Hadir) Hadir++;
                if (item.S) S++;
                if (item.I) I++;
                if (item.A) A++;
            }

            //set Total
            txtHadir.Text = Hadir.ToString();
            txtS.Text = S.ToString();
            txtI.Text = I.ToString();
            txtA.Text = A.ToString();
        }

        private void InitComponen()
        {
            //kelas
            var listKelas = new List<KelasModel>() 
            { 
                new KelasModel{KelasId = -1,NamaKelas = "---Pilih Kelas---"}
            };
            listKelas.AddRange(kelasDal.ListData().Select(x => new KelasModel
            {
                KelasId = x.KelasId,
                NamaKelas = x.NamaKelas
            }).ToList());
            kelasCombo.DataSource = listKelas;
            kelasCombo.DisplayMember = "NamaKelas";
            kelasCombo.ValueMember = "KelasId";

            //guru
            var listGuru = new List<GuruModel>()
            {
                new GuruModel{GuruId=-1,GuruName="---Pilih Guru---"}
            };
            listGuru.AddRange(guruDal.ListData(string.Empty, new { })
                .Select(x => new GuruModel
                {
                    GuruId= x.GuruId,
                    GuruName=x.GuruName
                }).ToList());
            guruCombo.DataSource = listGuru;
            guruCombo.DisplayMember = "GuruName";
            guruCombo.ValueMember = "GuruId";

            //mapel
            var listMapel = new List<MapelModel>()
            {
                new MapelModel{MapelId = -1, NamaMapel = "--Pilih Mapel---"}
            };
            listMapel.AddRange(mapelDal.ListData()
                .Select(x => new MapelModel
                {
                    MapelId = x.MapelId,
                    NamaMapel = x.NamaMapel
                }));
            mapelCombo.DataSource = listMapel;
            mapelCombo.DisplayMember = "NamaMapel";
            mapelCombo.ValueMember = "MapelId";
        }

        private void RegisterEvent()
        {
            btnListSiswa.Click += BtnListSiswa_Click;
        }
        private void BtnListSiswa_Click(object? sender, EventArgs e)
        {
            LoadDataSiswa();
        }

        private void ValidasiInput()
        {
            if (kelasCombo.Items.Count < 1 || mapelCombo.Items.Count < 1 || guruCombo.Items.Count < 0) return;

            Perubahan = TglGlobal != tglDT.Value.Date ? true
                : JamGlobal != txtJam.Text ? true
                : KelasIdGlobal != (int)kelasCombo.SelectedValue ? true
                : MapelIdGlobal != (int)mapelCombo.SelectedValue ? true
                : GuruIdGlobal != (int)guruCombo.SelectedValue ? true : false;

            if (Perubahan && LoadDataAwal != true)
            {
                if (MessageBox.Show("Simpan Perubahan Sebelumnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    SaveData();
            }

            TglGlobal = tglDT.Value.Date;
            JamGlobal = txtJam.Text;
            KelasIdGlobal = (int)kelasCombo.SelectedValue;
            MapelIdGlobal = (int)mapelCombo.SelectedValue;
            GuruIdGlobal = (int)guruCombo.SelectedValue;
            LoadDataAwal = false;
        }


        private void LoadDataSiswa()
        {
            int kelasId = (int)kelasCombo.SelectedValue;
            DateTime Tgl = tglDT.Value.Date;
            string Jam = txtJam.Text;

            var data = persensiDal.GetData(kelasId, Tgl, Jam);
            persensiIdGlobal = data == null ? 0 : data.PersensiId;
            if(data is null)
            {
                var listSiswa = ksdDal.ListData(kelasId).
                Select((x, index) => new PersensiDto
                {
                    NoUrut = index + 1,
                    Nama = x.NamaLengkap,
                    Hadir = false,
                    S = false,
                    I = false,
                    A = false,
                    Keterangan = "",
                    SiswaId = x.SiswaId
                });
                listPersensi.Clear();
                foreach (var item in listSiswa)
                    listPersensi.Add(item);
            }
            else
            {
                var listSiswa = persensiDetailDal.ListData(persensiIdGlobal).
                Select(x => new PersensiDto
                {
                    NoUrut = x.NoUrut,
                    Nama = x.NamaLengkap,
                    Hadir = x.StatusPersensi == "H",
                    S = x.StatusPersensi == "S",
                    I = x.StatusPersensi == "I",
                    A = x.StatusPersensi == "A",
                    Keterangan = string.Empty,
                    SiswaId = x.SiswaId
                });
                listPersensi.Clear();
                foreach (var item in listSiswa)
                    listPersensi.Add(item);
                UpdateTotalPersensi();
            }
        }

        private void SaveData()
        {
            int kelasId = KelasIdGlobal;
            int mapelId = MapelIdGlobal;
            int guruId = GuruIdGlobal;
            DateTime Tgl= TglGlobal;
            string Jam = JamGlobal;
            

            if (kelasId < 0 || mapelId < 0 || guruId < 0 || Jam == "")
            {
                MessageBox.Show("Data Tidak Valid!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var Persensi = new PersensiModel()
            {
                PersensiId = persensiIdGlobal,
                Tgl = Tgl,
                Jam = Jam,
                KelasId = kelasId,
                MapelId = mapelId,
                GuruId = guruId,
                ListPersensiDetail = listPersensi
                   .Select((x, index) => new PersensiDetailModel
                   {
                       NoUrut = x.NoUrut,
                       SiswaId = x.SiswaId,
                       StatusPersensi = x.Hadir ? "H" 
                                : x.S ? "S"
                                :x.I ? "I"
                                :x.A ? "A"
                                :"",
                       Keterangan = x.Keterangan,
                   }).ToList()
            };

            var cekData = persensiDal.GetData(kelasId, Tgl, Jam);
            if(cekData is null)
            {
                persensiIdGlobal = persensiDal.Insert(Persensi);
            }

            persensiDetailDal.Delete(persensiIdGlobal);
            persensiDetailDal.Insert(Persensi.ListPersensiDetail,persensiIdGlobal);
            LoadDataSiswa();
        }
    }
}

public class PersensiDto
{
    public int NoUrut {  get; set; }
    public string Nama {  get; set; }
    public bool Hadir { get; set; }
    public bool S { get; set; } = false;
    public bool I { get; set; } = false;
    public bool A { get; set; } = false;
    public string Keterangan {  get; set; }
    public int SiswaId { get; set; }
}


