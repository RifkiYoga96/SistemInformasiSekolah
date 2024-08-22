using Dapper;
using SistemInformasiSekolah.Dal;
using System.Data.SqlClient;
using System.Web;

namespace SistemInformasiSekolah
{
    public partial class Form1 : Form
    {
        private DbDal db;
        private readonly SiswaDal siswaDal;
        private readonly SiswaRiwayatDal siswaRiwayatDal;
        private readonly SiswaWaliDal siswaWaliDal;
        private readonly SiswaLulusDal siswaLulusDal;
        private readonly SiswaBeasiswaDal siswaBeasiswaDal;


        public Form1()
        {
            InitializeComponent();
            initCombo();
            LoadData();
            db = new DbDal();
            siswaDal = new SiswaDal();
            siswaRiwayatDal = new SiswaRiwayatDal();
            siswaLulusDal = new SiswaLulusDal();
            siswaWaliDal = new SiswaWaliDal();
            siswaBeasiswaDal = new SiswaBeasiswaDal();
        }

        #region PROCEDURE_ISI

        public void initCombo()
        {
            //Agama
            List<string> Agama = new List<string>() { "ISLAM", "KRISTEN", "KATOLIK", "HINDU", "BUDHA", "KONGHUCU" };
            comboAgamaAyah.DataSource = new List<string>(Agama);
            comboAgamaIbu.DataSource = new List<string>(Agama);
            comboAgamaWali.DataSource = new List<string>(Agama);
            comboAgamaSiswa.DataSource = new List<string>(Agama);

            //Yatim
            List<string> Yatim = new List<string>() { "Hidup", "Yatim", "Piatu", "Yatim-Piatu" };
            comboYatim.DataSource = Yatim;

            //Status Tinggal
            statusTinggalCombo.Items.Add("DENGAN ORTU");
            statusTinggalCombo.Items.Add("DENGAN SAUDARA");
            statusTinggalCombo.Items.Add("DI ASRAMA");
            statusTinggalCombo.SelectedIndex = 0;
        }
        #endregion

        #region SAVE DATA
        private void SaveSiswa()
        {
            var siswaId = SaveSiswaPersonal();
            SaveSiswaRiwayat(siswaId);
            SaveSiswaWali(siswaId);
            SaveSiswaLulus(siswaId);
        }

        private int SaveSiswaPersonal()
        {
            var siswaId = SiswaIDtxt.Text == string.Empty ? 0 :
                int.Parse(SiswaIDtxt.Text);
            var siswa = new SiswaModel
            {
                SiswaId = siswaId,
                NamaLengkap = txtNamaLengkap.Text,
                NamaPanggil = txtNamaPanggil.Text,
                Gender = radioLaki.Checked ? 1 : 0,
                TmpLahir = txtTempatLahir.Text,
                TglLahir = tglLahirSiswa.Value,
                Agama = comboAgamaSiswa.SelectedItem.ToString() ?? string.Empty,
                Kewarganegaraan = txtKewarganegara.Text,
                NIK = txtNIKSiswa.Text,
                AnakKe = (int)AnakKeNumeric.Value,
                JmlhSdrKandung = (int)JumSauKanNumeric.Value,
                JmlhSdrTiri = (int)JumSauTiNumeric.Value,
                JmlhSdrAngkat = (int)JumSauAngNumeric.Value,
                YatimPiatu = comboYatim.SelectedItem.ToString() ?? string.Empty,
                Bahasa = txtBahasa.Text,
                Alamat = txtAlamatSiswa.Text,
                NoTelp = txtNoHpRumah.Text,
                TngglDengan = statusTinggalCombo.SelectedItem.ToString() ?? string.Empty,
                JrkKeSekolah = (int)jarakSekolahNumeric.Value,
                TransportSekolah = txtTransportasi.Text
            };
            if (siswa.SiswaId == 0)
            {
                siswaId = siswaDal.Insert(siswa);
                MessageBox.Show("jsjs");
            }
            else
            {
                siswaDal.Update(siswa);
            }
            return siswaId;
        }

        private void SaveSiswaRiwayat(int siswaId)
        {
            string goldar = string.Empty;
            if (ARadio.Checked) goldar = "A";
            if (BRadio.Checked) goldar = "B";
            if (ABRadio.Checked) goldar = "AB";
            if (ORadio.Checked) goldar = "O";

            var siswaRiwayat = new SiswaRiwayatModel
            {
                SiswaId = siswaId,
                GolDarah = goldar,
                RiwayatPenyakit = txtPenyakitDiderita.Text,
                KelainanJasmani = radioTidak.Checked ? "Tidak" : txtJikaYa.Text,
                TinggiBdn = (int)numericTB.Value,
                BeratBdn = (int)numericTB.Value,
                LulusanDr = txtLulusanDari.Text,
                TglIjazah = tglIJAZAH.Value.Date,
                NoIjazah = txtNoIJAZAH.Text,
                LamaBljr = txtLamaBelajar.Text,
                PindahanDr = txtDariSekolah.Text,
                AlasanPindah = txtAlasanPindah.Text,
                DiterimaTingkat = txtDiterimaKelas.Text,
                KompKeahlian = txtKeahlian.Text,
                TglDiterima = tglDiterima.Value.Date,
                Kesenian = txtKesenian.Text,
                Olahraga = txtOlahraga.Text,
                Organisasi = txtMasyarakat.Text,
                Hobi = txtLainnya.Text,
                CitaCita = txtCitacita.Text,
                TglTinggalSekolah = tglMeninggalkanSekolah.Value.Date,
                AlasanTinggal = txtAlasanMeningalkanSekolah.Text,
                AkhirTamatBljr = tglTamatBelajar.Value.Date,
                AkhirNoIjazah = txtAkhirPendidikIJAZAH.Text
            };

            var cekNengDb = siswaRiwayatDal.GetData(siswaId);
            if (cekNengDb is null)
            {
                siswaRiwayatDal.Insert(siswaRiwayat);
            }
            else
            {
                siswaRiwayatDal.Update(siswaRiwayat);
            }
        }

        private void SaveSiswaWali(int siswaId)
        {

            var ayah = new SiswaWaliModel
            {
                //Ayah
                SiswaId = siswaId,
                JenisWali = "Ayah",
                Nama = txtAyahNama.Text,
                TmpLahir = txtTempatLahirAyah.Text,
                TglLahir = tglLahirAyah.Value,
                Agama = comboAgamaAyah.SelectedItem.ToString() ?? string.Empty,
                Kewarga = (radioWNIAyah.Checked) ? "WNI" : "Asing",
                Pendidikan = txtPendidikanAyah.Text,
                Pekerjaan = txtPekerjaanAyah.Text,
                Penghasilan = (decimal)numericGajiAyah.Value,
                Alamat = txtAlamatAyah.Text,
                NoTelp = txtNoTelpAyah.Text,
                NoKK = txtNoKKayah.Text,
                NIK = txtNIKAyah.Text,
                StatusHidup = radioHidupAyah.Checked ? "Masih Hidup" : "Sudah Meninggal"
            };

            var ibu = new SiswaWaliModel
            {
                SiswaId = siswaId,
                JenisWali = "Ibu",
                Nama = txtNamaIbu.Text,
                TmpLahir = txtTempatLahirIbu.Text,
                TglLahir = tglLahirIbu.Value,
                Agama = comboAgamaIbu.SelectedItem.ToString() ?? string.Empty,
                Kewarga = (radioWNIIbu.Checked) ? "WNI" : "Asing",
                Pendidikan = txtPendidikanIbu.Text,
                Pekerjaan = txtPekerjaanIbu.Text,
                Penghasilan = (decimal)numericGajiIbu.Value,
                Alamat = txtAlamatIbu.Text,
                NoTelp = txtNoHPIbu.Text,
                StatusHidup = radioHidupIbu.Checked ? "Masih Hidup" : "Sudah Meninggal"
            };

            var wali = new SiswaWaliModel
            {
                SiswaId = siswaId,
                JenisWali = "Wali",
                Nama = txtNamaWali.Text,
                TmpLahir = txtTempatLahirWali.Text,
                TglLahir = tglLahirWali.Value,
                Agama = comboAgamaWali.SelectedItem.ToString() ?? string.Empty,
                Kewarga = (radioWNIWali.Checked) ? "WNI" : "Asing",
                Pendidikan = txtPendidikanWali.Text,
                Pekerjaan = txtPekerjaanWali.Text,
                Penghasilan = (decimal)numericGajiWali.Value,
                Alamat = txtAlamatWali.Text,
                NoTelp = txtNoHPWali.Text
            };
            var ListWali = new List<SiswaWaliModel>() { ayah, ibu, wali };
            /*
                        var cekNengDb = siswaWaliDal.GetData(siswaId);
                        if (cekNengDb == null)
                            siswaWaliDal.Insert(ListWali);
                        else
                            siswaWaliDal.Update(ListWali);*/

            siswaWaliDal.Delete(siswaId);
            siswaWaliDal.Insert(ListWali);

        }

        private void SaveSiswaLulus(int siswaId)
        {
            var siswalulus = new SiswaLulusModel
            {
                SiswaId = siswaId,
                LanjutDi = txtMelanjutkanDi.Text,
                TglMulaiKerja = tglBekerja.Value.Date,
                NamaPerusahaan = txtNamaPerusahaan.Text,
                Penghasilan = (decimal)numericPendapatan.Value,
            };
            var cekNengDb = siswaLulusDal.GetData(siswaId);
            if (cekNengDb == null)
                siswaLulusDal.Insert(siswalulus);
            else
                siswaLulusDal.Update(siswalulus);
        }

        #endregion

        #region GET DATA
        public void GetData(int siswaId)
        {

            GetSiswa(siswaId);
        }
         public void GetSiswa(int siswaId)
        {
            var siswa = siswaDal.GetData(siswaId);
            if (siswa is null)
            {
                MessageBox.Show("Data not Found");
                return;
            }
            SiswaIDtxt.Text = siswa.SiswaId.ToString();
            txtNamaLengkap.Text = siswa.NamaLengkap;
            txtNamaPanggil.Text = siswa.NamaPanggil;
            if (radioLaki.Checked)
                radioLaki.Checked = true;
            else
                radioPerempuan.Checked = true;
            txtTempatLahir.Text = siswa.TmpLahir;
            tglLahirSiswa.Value = siswa.TglLahir;
            foreach (var item in comboAgamaSiswa.Items)
                if (item.ToString() == siswa.Agama)
                    comboAgamaSiswa.SelectedItem = item;
            txtKewarganegara.Text = siswa.Kewarganegaraan;
            txtNIKSiswa.Text = siswa.NIK;
            AnakKeNumeric.Value = siswa.AnakKe;
            JumSauKanNumeric.Value = siswa.JmlhSdrKandung;
            JumSauTiNumeric.Value = siswa.JmlhSdrTiri;
            JumSauAngNumeric.Value = siswa.JmlhSdrAngkat;
            foreach (var item in comboYatim.Items)
                if (item.ToString() == siswa.YatimPiatu)
                    comboYatim.SelectedItem = item;
            txtBahasa.Text = siswa.Bahasa;
            txtAlamatSiswa.Text = siswa.Alamat;
            txtNoHpRumah.Text = siswa.NoTelp;
            foreach (var item in statusTinggalCombo.Items)
                if (item.ToString() == siswa.TngglDengan)
                    statusTinggalCombo.SelectedItem = item;
            jarakSekolahNumeric.Value = siswa.JrkKeSekolah;
            txtTransportasi.Text = siswa.TransportSekolah;
        }
        #endregion

        #region HELPER

        public void LoadData()
        {
            const string sql = @"SELECT SiswaID,NamaLengkap,Alamat FROM Siswa";
            var koneksi = new SqlConnection(DbDal.DB());
            var load = koneksi.Query<ListDataModel>(sql);
            dataGridView2.DataSource = load;
        }

        #endregion


        private void button4_Click(object sender, EventArgs e)
        {
            SaveSiswa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSiswa();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        public class ListDataModel
        {
            public int SiswaId { get; set; }
            public string NamaLengkap { get; set; }
            public string Alamat { get; set; }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            var siswaID = dataGridView2.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (siswaID is null)
                return;
            GetData(int.Parse(siswaID));
            tabControl1.SelectedIndex = 1;
        }
    }
}
