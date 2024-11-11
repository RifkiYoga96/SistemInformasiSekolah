using Dapper;
using SistemInformasiSekolah.Dal;
using SistemInformasiSekolah.Kesiswaan.Dal;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Reflection;
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

        private readonly BindingSource beasiswaBinding;
        private readonly BindingList<ListBeaDTO> beaSiswaList;

        public string lokasiPhoto = string.Empty;
        private int SiswaIdGlobal = 0;

        public Form1()
        {
            InitializeComponent();

            db = new DbDal();
            siswaDal = new SiswaDal();
            siswaRiwayatDal = new SiswaRiwayatDal();
            siswaLulusDal = new SiswaLulusDal();
            siswaWaliDal = new SiswaWaliDal();
            siswaBeasiswaDal = new SiswaBeasiswaDal();
            beaSiswaList = new BindingList<ListBeaDTO>();
            beasiswaBinding = new BindingSource
            {
                DataSource = beaSiswaList
            };


            initCombo();
            LoadData();
            InitGrid();
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


        public void InitGrid()
        {

            BeasiswaGrid.DataSource = beasiswaBinding;
            /*  BeasiswaGrid.Columns["Tahun"].Width = 50;
              BeasiswaGrid.Columns["Kelas"].Width = 50;
              BeasiswaGrid.Columns["Penyedia"].Width = 200;*/
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView2.ColumnHeadersHeight = 30;
        }
        #endregion

        #region EVENT 
        #endregion

        #region SAVE DATA
        private void SaveSiswa()
        {
            var siswaId = SaveSiswaPersonal();
            SaveSiswaRiwayat(siswaId);
            SaveSiswaWali(siswaId);
            SaveSiswaLulus(siswaId);
            SaveBeasiswa(siswaId);
            LoadData();
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
                BeratBdn = (int)numericBB.Value,
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
                NoKK = txtNoKKIbu.Text,
                NIK = txtNIKIbu.Text,
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
                NoTelp = txtNoHPWali.Text,
                NoKK = txtNoKKWali.Text,
                NIK = txtNIKWali.Text,
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

        private void SaveBeasiswa(int siswaId)
        {
            var listBeasiswa = new List<SiswaBeasiswaModel>();
            siswaBeasiswaDal.Delete(siswaId);
            foreach (var item in beaSiswaList)
            {
                var newItem = new SiswaBeasiswaModel
                {
                    SiswaId = siswaId,
                    NoUrut = listBeasiswa.Count + 1,
                    Kelas = item.Kelas,
                    Tahun = item.Tahun,
                    AsalBeasiswa = item.Penyedia
                };
                if ($"{newItem.Kelas}{newItem.Tahun}" == string.Empty)
                    continue;
                listBeasiswa.Add(newItem);
            }
            siswaBeasiswaDal.Insert(listBeasiswa);
        }

        private void UpdatePhotoSiswa()
        {
            var siswa = siswaDal.GetData(SiswaIdGlobal);
            if (siswa is null)
            {
                photoSiswaBox.Image = null;
                lokasiPhoto = string.Empty;
                return;
            }
            siswa.LokasiPhoto = lokasiPhoto;
            siswaDal.Update(siswa);
        }
        #endregion

        #region GET DATA
        public void GetData(int siswaId)
        {
            GetSiswa(siswaId);
            GetSiswaRiwayat(siswaId);
            GetSiswaWali(siswaId);
            GetSiswaLulus(siswaId);
            GetSiswaBeasiswa(siswaId);
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
            if (siswa.Gender == 1)
                radioLaki.Checked = true;
            else if (siswa.Gender == 0)
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

        public void GetSiswaRiwayat(int SiswaId)
        {
            var siswaRiwayat = siswaRiwayatDal.GetData(SiswaId);
            if (siswaRiwayat is null)
            {
                MessageBox.Show("Data not found");
                return;
            }
            string goldar = siswaRiwayat.GolDarah;
            if (goldar == "A") ARadio.Checked = true;
            if (goldar == "B") BRadio.Checked = true;
            if (goldar == "AB") ABRadio.Checked = true;
            if (goldar == "O") ORadio.Checked = true;

            txtPenyakitDiderita.Text = siswaRiwayat.RiwayatPenyakit;
            if (siswaRiwayat.KelainanJasmani == "Tidak")
            {
                radioTidak.Checked = true;
            }
            else
            {
                radioYa.Checked = true;
                txtJikaYa.Text = siswaRiwayat.KelainanJasmani;
            }
            numericTB.Value = siswaRiwayat.TinggiBdn;
            numericBB.Value = siswaRiwayat.BeratBdn;
            txtLulusanDari.Text = siswaRiwayat.LulusanDr;
            tglIJAZAH.Value = siswaRiwayat.TglIjazah;
            txtNoIJAZAH.Text = siswaRiwayat.NoIjazah;
            txtLamaBelajar.Text = siswaRiwayat.LamaBljr;
            txtDariSekolah.Text = siswaRiwayat.PindahanDr;
            txtAlasanPindah.Text = siswaRiwayat.AlasanPindah;
            txtDiterimaKelas.Text = siswaRiwayat.DiterimaTingkat;
            txtKeahlian.Text = siswaRiwayat.KompKeahlian;
            tglDiterima.Value = siswaRiwayat.TglDiterima;
            txtKesenian.Text = siswaRiwayat.Kesenian;
            txtOlahraga.Text = siswaRiwayat.Olahraga;
            txtMasyarakat.Text = siswaRiwayat.Organisasi;
            txtLainnya.Text = siswaRiwayat.Hobi;
            txtCitacita.Text = siswaRiwayat.CitaCita;
            tglMeninggalkanSekolah.Value = siswaRiwayat.TglTinggalSekolah;
            txtAlasanMeningalkanSekolah.Text = siswaRiwayat.AlasanTinggal;
            tglTamatBelajar.Value = siswaRiwayat.AkhirTamatBljr;
            txtAkhirPendidikIJAZAH.Text = siswaRiwayat.AkhirNoIjazah;
        }

        public void GetSiswaWali(int siswaId)
        {
            var listWali = siswaWaliDal.GetData(siswaId);
            if (listWali is null) return;

            //Ayah
            var ayah = listWali.FirstOrDefault(a => a.JenisWali == "Ayah");
            if (ayah is null) return;
            txtAyahNama.Text = ayah.Nama;
            txtTempatLahirAyah.Text = ayah.TmpLahir;
            tglLahirAyah.Value = ayah.TglLahir;
            foreach (var item in comboAgamaAyah.Items)
                if (item.ToString() == ayah.Agama)
                    comboAgamaAyah.SelectedItem = item;
            if (ayah.Kewarga == "WNI")
                radioWNIAyah.Checked = true;
            else if (ayah.Kewarga == "Asing")
                radioAsingAyah.Checked = true;
            txtPendidikanAyah.Text = ayah.Pendidikan;
            txtPekerjaanAyah.Text = ayah.Pekerjaan;
            numericGajiAyah.Value = ayah.Penghasilan;
            txtAlamatAyah.Text = ayah.Alamat;
            txtNoTelpAyah.Text = ayah.NoTelp;
            txtNoKKayah.Text = ayah.NoKK;
            txtNIKAyah.Text = ayah.NIK;
            if (ayah.StatusHidup == "Masih Hidup")
                radioHidupAyah.Checked = true;
            else if (ayah.StatusHidup == "Sudah Meninggal")
                radioMatiAyah.Checked = true;

            //Ibu
            var ibu = listWali.FirstOrDefault(a => a.JenisWali == "Ibu");
            if (ibu is null) return;
            txtNamaIbu.Text = ibu.Nama;
            txtTempatLahirIbu.Text = ibu.TmpLahir;
            tglLahirIbu.Value = ibu.TglLahir;
            foreach (var item in comboAgamaIbu.Items)
                if (item.ToString() == ibu.Agama)
                    comboAgamaIbu.SelectedItem = item;
            if (ibu.Kewarga == "WNI")
                radioWNIIbu.Checked = true;
            else if (ibu.Kewarga == "Asing")
                radioAsingIbu.Checked = true;
            txtPendidikanIbu.Text = ibu.Pendidikan;
            txtPekerjaanIbu.Text = ibu.Pekerjaan;
            numericGajiIbu.Value = ibu.Penghasilan;
            txtAlamatIbu.Text = ibu.Alamat;
            txtNoHPIbu.Text = ibu.NoTelp;
            txtNoKKIbu.Text = ibu.NoKK;
            txtNIKIbu.Text = ibu.NIK;
            if (ibu.StatusHidup == "Masih Hidup")
                radioHidupIbu.Checked = true;
            else if (ibu.StatusHidup == "Sudah Meninggal")
                radioMatiIbu.Checked = true;

            //Wali
            var wali = listWali.FirstOrDefault(a => a.JenisWali == "Wali");
            if (wali is null) return;
            txtNamaWali.Text = wali.Nama;
            txtTempatLahirWali.Text = wali.TmpLahir;
            tglLahirWali.Value = wali.TglLahir;
            foreach (var item in comboAgamaWali.Items)
                if (item.ToString() == wali.Agama)
                    comboAgamaWali.SelectedItem = item;
            if (wali.Kewarga == "WNI")
                radioWNIWali.Checked = true;
            else if (wali.Kewarga == "Asing")
                radioAsingWali.Checked = true;
            txtPendidikanWali.Text = wali.Pekerjaan;
            numericGajiWali.Value = wali.Penghasilan;
            txtAlamatWali.Text = wali.Alamat;
            txtNoHPWali.Text = wali.NoTelp;
            txtNoKKWali.Text = wali.NoKK;
            txtNIKWali.Text = wali.NIK;
        }

        public void GetSiswaLulus(int siswaId)
        {
            var siswaLulus = siswaLulusDal.GetData(siswaId);
            if (siswaLulus == null) return;
            txtMelanjutkanDi.Text = siswaLulus.LanjutDi;
            tglBekerja.Value = siswaLulus.TglMulaiKerja;
            txtNamaPerusahaan.Text = siswaLulus.NamaPerusahaan;
            numericPendapatan.Value = siswaLulus.Penghasilan;
        }
        private void GetSiswaBeasiswa(int siswaId)
        {
            var listBea = siswaBeasiswaDal.ListData(siswaId)?.ToList();
            if (listBea is null)
                return;

            beaSiswaList.Clear();
            listBea.ForEach(x => beaSiswaList.Add(new ListBeaDTO
            {
                No = x.NoUrut,
                Kelas = x.Kelas,
                Tahun = x.Tahun,
                Penyedia = x.AsalBeasiswa
            }));
        }
        #endregion

        #region DELETE DATA

        public void DeleteData(int siswaId)
        {
            siswaDal.Delete(siswaId);
            siswaRiwayatDal.Delete(siswaId);
            siswaWaliDal.Delete(siswaId);
            siswaLulusDal.Delete(siswaId);
            siswaBeasiswaDal.Delete(siswaId);

            LoadData();
        }

        #endregion

        #region HELPER

        private void ClearInputan()
        {
            //Personal
            SiswaIDtxt.Clear();
            txtNamaLengkap.Clear();
            txtNamaPanggil.Clear();
            radioLaki.Checked = false;
            radioPerempuan.Checked = false;
            comboAgamaSiswa.SelectedIndex = 0;
            txtKewarganegara.Clear();
            txtNIKSiswa.Clear();
            AnakKeNumeric.Value = 0;
            JumSauKanNumeric.Value = 0;
            JumSauTiNumeric.Value = 0;
            JumSauAngNumeric.Value = 0;
            comboYatim.SelectedIndex = 0;
            txtBahasa.Clear();
            txtAlamatSiswa.Clear();
            txtNoHpRumah.Clear();
            statusTinggalCombo.SelectedIndex = 0;
            jarakSekolahNumeric.Value = 0;
            txtTransportasi.Clear();

            // Riwayat
            ARadio.Checked = false;
            BRadio.Checked = false;
            ABRadio.Checked = false;
            ORadio.Checked = false;
            txtPenyakitDiderita.Clear();
            radioTidak.Checked = false;
            radioYa.Checked = false;
            txtJikaYa.Clear();
            numericTB.Value = 0;
            numericBB.Value = 0;
            txtLulusanDari.Clear();
            tglIJAZAH.Value = DateTime.Today;
            txtNoIJAZAH.Clear();
            txtLamaBelajar.Clear();
            txtDariSekolah.Clear();
            txtAlasanPindah.Clear();
            txtDiterimaKelas.Clear();
            txtKeahlian.Clear();
            tglDiterima.Value = DateTime.Today;
            txtKesenian.Clear();
            txtOlahraga.Clear();
            txtMasyarakat.Clear();
            txtLainnya.Clear();
            txtCitacita.Clear();
            tglMeninggalkanSekolah.Value = DateTime.Today;
            txtAlasanMeningalkanSekolah.Clear();
            tglTamatBelajar.Value = DateTime.Today;
            txtAkhirPendidikIJAZAH.Clear();
            beaSiswaList.Clear();

            //Wali
            // Ayah
            txtAyahNama.Clear();
            txtTempatLahirAyah.Clear();
            tglLahirAyah.Value = DateTime.Today;
            comboAgamaAyah.SelectedIndex = 0;
            radioWNIAyah.Checked = false;
            radioAsingAyah.Checked = false;
            txtPendidikanAyah.Clear();
            txtPekerjaanAyah.Clear();
            numericGajiAyah.Value = 0;
            txtAlamatAyah.Clear();
            txtNoTelpAyah.Clear();
            txtNoKKayah.Clear();
            txtNIKAyah.Clear();
            radioHidupAyah.Checked = false;
            radioMatiAyah.Checked = false;

            // Ibu
            txtNamaIbu.Clear();
            txtTempatLahirIbu.Clear();
            tglLahirIbu.Value = DateTime.Today;
            comboAgamaIbu.SelectedIndex = 0;
            radioWNIIbu.Checked = false;
            radioAsingIbu.Checked = false;
            txtPendidikanIbu.Clear();
            txtPekerjaanIbu.Clear();
            numericGajiIbu.Value = 0;
            txtAlamatIbu.Clear();
            txtNoHPIbu.Clear();
            txtNoKKIbu.Clear();
            txtNIKIbu.Clear();
            radioHidupIbu.Checked = false;
            radioMatiIbu.Checked = false;

            // Wali
            txtNamaWali.Clear();
            txtTempatLahirWali.Clear();
            tglLahirWali.Value = DateTime.Today;
            comboAgamaWali.SelectedIndex = 0;
            radioWNIWali.Checked = false;
            radioAsingWali.Checked = false;
            txtPendidikanWali.Clear();
            txtPekerjaanWali.Clear();
            numericGajiWali.Value = 0;
            txtAlamatWali.Clear();
            txtNoHPWali.Clear();
            txtNoKKWali.Clear();
            txtNIKWali.Clear();

            //Lulus
            txtMelanjutkanDi.Clear();
            tglBekerja.Value = DateTime.Today;
            txtNamaPerusahaan.Clear();
            numericPendapatan.Value = 0;
        }


        public void LoadData()
        {
            string search = txtSearch.Text;
            string sql = @"SELECT SiswaID,NamaLengkap,Alamat FROM Siswa";
            if (search != "") sql += " WHERE NamaLengkap LIKE '%'+@search+'%'";
            var koneksi = new SqlConnection(DbDal.DB());
            var load = koneksi.Query<ListDataModel>(sql, new {search=search});
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

        public void GetFromDGV()
        {
            var siswaID = dataGridView2.CurrentRow.Cells["SiswaId"].Value.ToString();
            if (siswaID is null)
                return;
            GetData(int.Parse(siswaID));
        }

        private void dataGridView2_DoubleClick_1(object sender, EventArgs e)
        {
            GetFromDGV();
            tabControl1.SelectedIndex = 1;
        }

        public class ListDataModel
        {
            public int SiswaId { get; set; }
            public string NamaLengkap { get; set; }
            public string Alamat { get; set; }
        }

        public class ListBeaDTO
        {
            public int No { get; set; }
            public string Tahun { get; set; }
            public string Kelas { get; set; }
            public string Penyedia { get; set; }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            if (SiswaIDtxt.Text == "" && txtNamaLengkap.Text != "")
            {
                var dialog = MessageBox.Show("Buat Data Baru?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No) return;
            }
            ClearInputan();
            tabControl1.SelectedIndex = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SiswaIDtxt.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var konfir = MessageBox.Show("Apakah Anda Yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (konfir == DialogResult.No) return;
                DeleteData(int.Parse(SiswaIDtxt.Text));
            }

        }

        private void btnPilihPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                FilterIndex = 1,
                Title = "Pilih Photo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photoSiswaBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                photoSiswaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                lokasiPhoto = openFileDialog.FileName;

                UpdatePhotoSiswa();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];

                string siswaId = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
                string siswaName = selectedRow.Cells[1].Value?.ToString() ?? "[Nama Siswa Kosong]";

                SiswaIdGlobal = Convert.ToInt32(siswaId);
                lblNamaSiswa.Text = siswaName;

                var siswa = siswaDal.GetData(Convert.ToInt16(siswaId));
                lokasiPhoto = siswa?.LokasiPhoto ?? string.Empty;
                if (lokasiPhoto != string.Empty)
                {
                    photoSiswaBox.Image = Image.FromFile(lokasiPhoto);
                    photoSiswaBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    photoSiswaBox.Image = null;
                }

            }
        }

        private void btnHapusPhoto_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show("Hapus Photo?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.No) return;

            int siswaId = SiswaIdGlobal;
            int index = dataGridView2.CurrentRow.Index;

            siswaDal.DeletePhoto(siswaId);
            photoSiswaBox.Image = null;
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[index].Selected = true;
            }
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var siswaId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            var siswaName = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

            SiswaIdGlobal = Convert.ToInt32(siswaId);
            lblNamaSiswa.Text = siswaName;

            var siswa = siswaDal.GetData(Convert.ToInt16(siswaId)); // info di bawah
            lokasiPhoto = siswa?.LokasiPhoto ?? string.Empty;
            if (lokasiPhoto != string.Empty)
            {
                photoSiswaBox.Image = Image.FromFile(lokasiPhoto);
                photoSiswaBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                photoSiswaBox.Image = Properties.Resources.Propil;
            }

            lblNamaSiswa.Location = new Point(panel12.Width / 2 - lblNamaSiswa.Width / 2, lblNamaSiswa.Location.Y);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
