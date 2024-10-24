using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Kelas_Siswa;
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
        public FormKelasSiswa()
        {
            InitializeComponent();

            kelasSiswaDal = new KelasSiswaDal();
            kelasSiswaDetailDal = new KelasSiswaDetailDal();
            siswaDal = new SiswaDal();
            guruDal = new GuruDal();
            kelasDal = new KelasDal();
            allSiswaBinding.DataSource = allSiswaList;
            kelasSiswaBinding.DataSource = kelasSiswaBinding;

            gridSiswa.DataSource = allSiswaBinding;
            gridKelasSiswa.DataSource = kelasSiswaBinding;

            InitCombo();
            RegisterEvent();
        }
        private void InitCombo()
        {
            kelasCombo.DataSource = kelasDal.ListData()
                .Select(x => new {KelasId=x.KelasId,KelasName=x.NamaKelas}).ToList();
            kelasCombo.DisplayMember = "KelasName";
            kelasCombo.ValueMember = "KelasId";

            waliKelasCombo.DataSource = guruDal.ListData(string.Empty, new {})
                .Select(x => new {GuruId=x.GuruId,GuruName=x.GuruName}).ToList();
            waliKelasCombo.DisplayMember = "GuruName";
            waliKelasCombo.DisplayMember = "GuruId";
        }
        private void RegisterEvent()
        {
            btnSave.Click += BtnSave_Click;
            kelasCombo.SelectedIndexChanged += KelasCombo_SelectedIndexChanged;
        }

        private void KelasCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            if (kelasCombo.SelectedIndex == -1) return;
            int kelasId = (int)kelasCombo.SelectedValue;
            var kelasSiswa = kelasSiswaDal.GetData(kelasId);
            if(kelasSiswa is null)
            {
                ClearFrom();
                return;
            }
            txtTahunAjaran.Text = kelasSiswa.TahunAjaran;
            waliKelasCombo.SelectedValue = kelasSiswa.WaliKelasId;
            var ListkelasSiswa = kelasSiswaDetailDal.ListData(kelasSiswa.KelasId)?.ToList() ?? new();
            kelasSiswaList.Clear();
            var kelasSiswaTemp = ListkelasSiswa.Select(x => new SiswaDto(x.SiswaId,x.SiswaName))?.ToList() ?? new();
            foreach (var item in kelasSiswaTemp) kelasSiswaList.Add(item);
            ListKelasTersedia();
            
        }
        private void ClearFrom()
        {
            txtTahunAjaran.Clear();
            waliKelasCombo.SelectedIndex = -1;
            allSiswaList.Clear();
            kelasSiswaList.Clear();
            ListKelasTersedia();
        }
        private void ListKelasTersedia()
        {
            var allSiswa = siswaDal.ListData()?.ToList() ?? new List<SiswaModel>();
            var siswaInKelas = kelasSiswaDetailDal.ListData()?.ToList() ?? new List<KelasSiswaDetailModel>();
            var siswaIdInKelas = siswaInKelas.Select(x => x.SiswaId).ToList() ?? new List<int>();

            allSiswa.RemoveAll(x => siswaIdInKelas.Contains(x.SiswaId));

            allSiswaList.Clear();
            var listSiswaTemp = allSiswa.Select(x => new SiswaDto(x.SiswaId,x.NamaLengkap))?.ToList() ?? new List<SiswaDto>();
            foreach (var item in listSiswaTemp) allSiswaList.Add(item);
            gridSiswa.Refresh();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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