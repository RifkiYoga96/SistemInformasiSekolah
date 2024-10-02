using Dapper;
using SistemInformasiSekolah.Kesiswaan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Kesiswaan.Dal
{
    public class SiswaRiwayatDal
    {
        DynamicParameters dp = new DynamicParameters();
        public int Insert(SiswaRiwayatModel siswaRiwayat)
        {
            const string sql = @"
                    INSERT INTO SiswaRiwayat(
                        SiswaId, GolDarah, RiwayatPenyakit, KelainanJasmani, TinggiBdn,
                        BeratBdn, LulusanDr, TglIjazah, NoIjazah, LamaBljr, PindahanDr,
                        AlasanPindah, DiterimaTingkat, KompKeahlian, TglDiterima, Kesenian,
                        Olahraga, Organisasi, Hobi, CitaCita, TglTinggalSekolah, AlasanTinggal,
                        AkhirTamatBljr, AkhirNoIjazah)
                    VALUES (
                        @SiswaId, @GolDarah, @RiwayatPenyakit, @KelainanJasmani, @TinggiBdn,
                        @BeratBdn, @LulusanDr, @TglIjazah, @NoIjazah, @LamaBljr, @PindahanDr,
                        @AlasanPindah, @DiterimaTingkat, @KompKeahlian, @TglDiterima, @Kesenian,
                        @Olahraga, @Organisasi, @Hobi, @CitaCita, @TglTinggalSekolah, @AlasanTinggal,
                        @AkhirTamatBljr, @AkhirNoIjazah)";


            dp.Add("@SiswaId", siswaRiwayat.SiswaId, DbType.String);
            dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.String);
            dp.Add("@RiwayatPenyakit", siswaRiwayat.RiwayatPenyakit, DbType.String);
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String);
            dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, DbType.Int16);
            dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, DbType.Int16);
            dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, DbType.String);
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.Date);
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String);
            dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, DbType.String);
            dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, DbType.String);
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, DbType.String);
            dp.Add("@KompKeahlian", siswaRiwayat.KompKeahlian, DbType.String);
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.Date);
            dp.Add("@Kesenian", siswaRiwayat.Kesenian, DbType.String);
            dp.Add("@Olahraga", siswaRiwayat.Olahraga, DbType.String);
            dp.Add("@Organisasi", siswaRiwayat.Organisasi, DbType.String);
            dp.Add("@Hobi", siswaRiwayat.Hobi, DbType.String);
            dp.Add("@CitaCita", siswaRiwayat.CitaCita, DbType.String);
            dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, DbType.Date);
            dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, DbType.String);
            dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, DbType.Date);
            dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var insert = koneksi.Execute(sql, dp);
            return insert;

        }

        public int Update(SiswaRiwayatModel siswaRiwayat)
        {
            const string sql = @"
                        UPDATE SiswaRiwayat
                        SET
                            GolDarah = @GolDarah,
                            RiwayatPenyakit = @RiwayatPenyakit,
                            KelainanJasmani = @KelainanJasmani,
                            TinggiBdn = @TinggiBdn,
                            BeratBdn = @BeratBdn,
                            LulusanDr = @LulusanDr,
                            TglIjazah = @TglIjazah,
                            NoIjazah = @NoIjazah,
                            LamaBljr = @LamaBljr,
                            PindahanDr = @PindahanDr,
                            AlasanPindah = @AlasanPindah,
                            DiterimaTingkat = @DiterimaTingkat,
                            KompKeahlian = @KompKeahlian,
                            TglDiterima = @TglDiterima,
                            Kesenian = @Kesenian,
                            Olahraga = @Olahraga,
                            Organisasi = @Organisasi,
                            Hobi = @Hobi,
                            CitaCita = @CitaCita,
                            TglTinggalSekolah = @TglTinggalSekolah,
                            AlasanTinggal = @AlasanTinggal,
                            AkhirTamatBljr = @AkhirTamatBljr,
                            AkhirNoIjazah = @AkhirNoIjazah
                        WHERE SiswaId = @SiswaId";

            dp.Add("@SiswaId", siswaRiwayat.SiswaId, DbType.String);
            dp.Add("@GolDarah", siswaRiwayat.GolDarah, DbType.String);
            dp.Add("@RiwayatPenyakit", siswaRiwayat.RiwayatPenyakit, DbType.String);
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, DbType.String);
            dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, DbType.Int16);
            dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, DbType.Int16);
            dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, DbType.String);
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, DbType.Date);
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, DbType.String);
            dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, DbType.String);
            dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, DbType.String);
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, DbType.String);
            dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, DbType.String);
            dp.Add("@KompKeahlian", siswaRiwayat.KompKeahlian, DbType.String);
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, DbType.Date);
            dp.Add("@Kesenian", siswaRiwayat.Kesenian, DbType.String);
            dp.Add("@Olahraga", siswaRiwayat.Olahraga, DbType.String);
            dp.Add("@Organisasi", siswaRiwayat.Organisasi, DbType.String);
            dp.Add("@Hobi", siswaRiwayat.Hobi, DbType.String);
            dp.Add("@CitaCita", siswaRiwayat.CitaCita, DbType.String);
            dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, DbType.Date);
            dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, DbType.String);
            dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, DbType.Date);
            dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var update = koneksi.Execute(sql, dp);
            return update;
        }

        public SiswaRiwayatModel? GetData(int siswaId)
        {
            const string sql = @"SELECT * FROM SiswaRiwayat WHERE SiswaId=@SiswaId";
            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, DbType.Int32);
            using var koneksi = new SqlConnection(DbDal.DB());
            var get = koneksi.QueryFirstOrDefault<SiswaRiwayatModel>(sql, dp);
            return get;
        }

        public void Delete(int siswaId)
        {
            const string sql = @"DELETE FROM SiswaRiwayat WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new { SiswaId = siswaId });
        }
    }
}
