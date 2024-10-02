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
        public FormJadwalPelajaran()
        {
            InitializeComponent();
        }

        private void SaveData()
        {
            int IdMapel = idMapelTxt.Text != string.Empty ? int.Parse(idMapelTxt.Text) : 0;
            string namaKelas = namaKelasTxt.Text;
            string jenisJadwal = comboJenisJadwal.SelectedItem.ToString() ?? string.Empty;
            string hari = comboHari.SelectedItem.ToString() ?? string.Empty;
            TimeSpan jamMulai = jamMulaiDT.Value.TimeOfDay;
            TimeSpan jamSelesai = jamMulaiDT.Value.TimeOfDay;
            
        }
    }
}
