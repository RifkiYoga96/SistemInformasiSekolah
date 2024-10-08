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

namespace SistemInformasiSekolah.Jadwal_Pelajaran
{
    public partial class FormKelasJadwal : Form
    {
        public string Kelas { get; set; }
        private readonly JurusanDal jurusanDal;
        private readonly KelasDal kelasDal;
        public FormKelasJadwal(string namaKelas)
        {
            InitializeComponent();
            jurusanDal = new JurusanDal();
            kelasDal = new KelasDal();
            this.Kelas = namaKelas;
            InitCombo();
            RegisterEvent();
        }
        private void InitCombo()
        {
            jurusanCombo.DataSource = jurusanDal.ListData();
            jurusanCombo.DisplayMember = "Code";
            jurusanCombo.ValueMember = "JurusanId";

            if (Kelas == string.Empty) return;
            string[] arrkelas = Kelas.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (arrkelas[0] == "10") radio10.Checked = true;
            if (arrkelas[0] == "11") radio11.Checked = true;
            if (arrkelas[0] == "12") radio12.Checked = true;
            foreach (var x in jurusanCombo.Items)
                if (x is JurusanModel j)
                    if (j.Code == arrkelas[1])
                        jurusanCombo.SelectedItem = j;
            string flag = arrkelas.Length >= 3 ? arrkelas[2] : string.Empty;
            SetComponen(flag);
        }

        private void SetComponen(string flag)
        {
            int tingkat = radio10.Checked ? 10 : radio11.Checked ? 11 : radio12.Checked ? 12 : 0;
            int idJurusan = (int)jurusanCombo.SelectedValue;
            if (tingkat == 0) return;
            var getFlag = kelasDal.GetDataFlag(tingkat, idJurusan);
            if (!getFlag.Any()) return;
            rombelCombo.DataSource = getFlag.Select(x => x.Flag).ToList();
            if (flag != string.Empty)
                foreach (var x in rombelCombo.Items)
                    if ((string)x == flag)
                        rombelCombo.SelectedItem = x;
            SetHasil();
        }
        private void SetHasil()
        {
            string tingkat = radio10.Checked ? "10" : radio11.Checked ? "11" : radio12.Checked ? "12" : string.Empty;
            string codeJurusan = ((JurusanModel)jurusanCombo.SelectedItem).Code;
            string flag = rombelCombo.SelectedItem?.ToString() ?? string.Empty;
            if (tingkat == string.Empty) return;
            txtHasil.Text = flag == string.Empty ? $"{tingkat} {codeJurusan}" : $"{tingkat} {codeJurusan}-{flag}";
        }


        private void RegisterEvent()
        {
            radio10.CheckedChanged += all_Changed;
            radio11.CheckedChanged += all_Changed;
            radio12.CheckedChanged += all_Changed;
            jurusanCombo.SelectedIndexChanged += all_Changed;
            rombelCombo.SelectedIndexChanged += rombel_Changed;
            btnAtur.Click += btnAtur_Click;
        }
        private void all_Changed(object? sender, EventArgs e)
        {
            SetComponen(string.Empty);
        }

        private void rombel_Changed(object? sender,EventArgs e)
        {
            SetHasil();
        }

        private void btnAtur_Click(object? sender,EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Kelas = txtHasil.Text;
            this.Close();
        }
    }
}
