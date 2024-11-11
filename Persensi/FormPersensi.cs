using SistemInformasiSekolah.Kelas_Siswa;
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
        private readonly Dal.KelasDal kelasDal;
        private readonly Dal.MapelDal mapelDal;
        private readonly Dal.GuruDal guruDal;
        private readonly KelasSiswaDetailDal ksdDal;
        private BindingSource bindingSource = new();
        private BindingList<PersensiDto> listPersensi = new();
        
        public FormPersensi()
        {
            InitializeComponent();
            persensiDal = new PersensiDal();
            kelasDal = new Dal.KelasDal();
            mapelDal = new Dal.MapelDal();
            guruDal = new Dal.GuruDal();
            ksdDal = new KelasSiswaDetailDal();
            bindingSource.DataSource = listPersensi;
            InitComponen();
            RegisterEvent();
            dataGridView1.AllowUserToAddRows = false;
            SettingGrid();
        }

        private void SettingGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += DataGridView1_CurrentCellDirtyStateChanged;
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
                        dataGridView1.Rows[e.RowIndex].Cells[i].Value = false;
        }

        private void InitComponen()
        {
            //kelas
            var kelas = kelasDal.ListData().Select(x => new
            {
                x.KelasId,
                x.NamaKelas
            }).ToList();
            kelasCombo.DataSource = kelas;
            kelasCombo.DisplayMember = "NamaKelas";
            kelasCombo.ValueMember = "KelasId";

            //guru
            var guru = guruDal.ListData(string.Empty, new { }).Select(x => new
            {
                x.GuruId,
                x.GuruName
            }).ToList();
            guruCombo.DataSource = guru;
            guruCombo.DisplayMember = "GuruName";
            guruCombo.ValueMember = "GuruId";

            //mapel
            var mapel = mapelDal.ListData().Select(x => new
            {
                x.MapelId,
                x.NamaMapel
            }).ToList();
            mapelCombo.DataSource = mapel;
            mapelCombo.DisplayMember = "NamaMapel";
            mapelCombo.ValueMember = "MapelId";
        }

        private void RegisterEvent()
        {
            kelasCombo.SelectedIndexChanged += KelasCombo_SelectedIndexChanged;
        }

        private void KelasCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadDataSiswa();
        }

        private DataGridViewCheckBoxColumn CreateCheckBox(string headerText, string Name)
        {
            return new DataGridViewCheckBoxColumn
            {
                HeaderText = headerText,
                Name = Name
            };
        }
        private void LoadDataSiswa()
        {
            int kelasId = (int)kelasCombo.SelectedValue;
            DateTime Tgl = tglDT.Value;
            string Jam = txtJam.Text;
            /*var data = persensiDal.GetData(kelasId,Tgl,Jam);
            if(data is null)
            {

            }*/
            var listSiswa = ksdDal.ListData(kelasId)
                .Select((x,index) => new PersensiDto
                {
                    NoUrut = index + 1,
                    Nama = x.NamaLengkap,
                    Keterangan = ""
                }).ToList();
            listPersensi.Clear();
            foreach (var item in listSiswa)
                listPersensi.Add(item);

            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns.Insert(2,CreateCheckBox("Hadir","Hadir"));
            dataGridView1.Columns.Insert(3,CreateCheckBox("S","S"));
            dataGridView1.Columns.Insert(4,CreateCheckBox("I","I"));
            dataGridView1.Columns.Insert(5,CreateCheckBox("A","A"));
        }
    }
}

public class PersensiDto
{
    public int NoUrut {  get; set; }
    public string Nama {  get; set; }
    public string Keterangan {  get; set; }
}


