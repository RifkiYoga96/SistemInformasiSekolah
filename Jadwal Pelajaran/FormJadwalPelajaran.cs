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
        private readonly MapelDal mapelDal;
        private readonly GuruDal guruDal;
        private int jadwalPelajaranId;
        public FormJadwalPelajaran()
        {
            InitializeComponent();
            mapelDal = new MapelDal();
            guruDal = new GuruDal();
            InitCombo();
        }
        private void InitCombo()
        {
            comboJenisJadwal.DataSource = new string[] {"Normada","Jurusan"};

            comboHari.DataSource = new string[] {"Senin","Selasa","Rabu","Kamis","Jum`at","Sabtu"};

            mapelCombo.DataSource = mapelDal.ListData();
            mapelCombo.DisplayMember = "NamaMapel";

            guruCombo.DataSource = guruDal.ListData(string.Empty, new {}).Select(x => new GuruModel { GuruId = x.GuruId, GuruName=x.GuruName}).ToList();
            guruCombo.DisplayMember = "GuruName";
        }
        private void SaveData()
        {
            string namaKelas = namaKelasTxt.Text != "---Pilih Nama Kelas---" ? namaKelasTxt.Text : string.Empty;
            string jenisJadwal = comboJenisJadwal.SelectedItem.ToString() ?? string.Empty;
            string hari = comboHari.SelectedItem.ToString() ?? string.Empty;
            TimeSpan jamMulai = jamMulaiDT.Value.TimeOfDay;
            TimeSpan jamSelesai = jamMulaiDT.Value.TimeOfDay;

            //if(namaKelas == "" || jenis)

            if(jadwalPelajaranId == 0)
            {
                if (MessageBox.Show("Insert Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            }
            else
            {
                if (MessageBox.Show("Insert Data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            }

            
        }

        #region EVENT
        private void RegisterEvent()
        {

        }
        #endregion
    }
}
