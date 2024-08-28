using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
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


            dp.Add("@SiswaId",siswaRiwayat.SiswaId, System.Data.DbType.String);
            dp.Add("@GolDarah",siswaRiwayat.GolDarah, System.Data.DbType.String);
            dp.Add("@RiwayatPenyakit",siswaRiwayat.RiwayatPenyakit, System.Data.DbType.String);
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, System.Data.DbType.String);
            dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, System.Data.DbType.Int16);
            dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, System.Data.DbType.Int16);
            dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, System.Data.DbType.String);
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, System.Data.DbType.Date);
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, System.Data.DbType.String);
            dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, System.Data.DbType.String);
            dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, System.Data.DbType.String);
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, System.Data.DbType.String);
            dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, System.Data.DbType.String);
            dp.Add("@KompKeahlian", siswaRiwayat.KompKeahlian, System.Data.DbType.String);
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, System.Data.DbType.Date);
            dp.Add("@Kesenian", siswaRiwayat.Kesenian, System.Data.DbType.String);
            dp.Add("@Olahraga", siswaRiwayat.Olahraga, System.Data.DbType.String);
            dp.Add("@Organisasi", siswaRiwayat.Organisasi, System.Data.DbType.String);
            dp.Add("@Hobi", siswaRiwayat.Hobi, System.Data.DbType.String);
            dp.Add("@CitaCita", siswaRiwayat.CitaCita, System.Data.DbType.String);
            dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, System.Data.DbType.Date);
            dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, System.Data.DbType.String);
            dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, System.Data.DbType.Date);
            dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, System.Data.DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var insert = koneksi.Execute(sql,dp);
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

            dp.Add("@SiswaId", siswaRiwayat.SiswaId, System.Data.DbType.String);
            dp.Add("@GolDarah", siswaRiwayat.GolDarah, System.Data.DbType.String);
            dp.Add("@RiwayatPenyakit", siswaRiwayat.RiwayatPenyakit, System.Data.DbType.String);
            dp.Add("@KelainanJasmani", siswaRiwayat.KelainanJasmani, System.Data.DbType.String);
            dp.Add("@TinggiBdn", siswaRiwayat.TinggiBdn, System.Data.DbType.Int16);
            dp.Add("@BeratBdn", siswaRiwayat.BeratBdn, System.Data.DbType.Int16);
            dp.Add("@LulusanDr", siswaRiwayat.LulusanDr, System.Data.DbType.String);
            dp.Add("@TglIjazah", siswaRiwayat.TglIjazah, System.Data.DbType.Date);
            dp.Add("@NoIjazah", siswaRiwayat.NoIjazah, System.Data.DbType.String);
            dp.Add("@LamaBljr", siswaRiwayat.LamaBljr, System.Data.DbType.String);
            dp.Add("@PindahanDr", siswaRiwayat.PindahanDr, System.Data.DbType.String);
            dp.Add("@AlasanPindah", siswaRiwayat.AlasanPindah, System.Data.DbType.String);
            dp.Add("@DiterimaTingkat", siswaRiwayat.DiterimaTingkat, System.Data.DbType.String);
            dp.Add("@KompKeahlian", siswaRiwayat.KompKeahlian, System.Data.DbType.String);
            dp.Add("@TglDiterima", siswaRiwayat.TglDiterima, System.Data.DbType.Date);
            dp.Add("@Kesenian", siswaRiwayat.Kesenian, System.Data.DbType.String);
            dp.Add("@Olahraga", siswaRiwayat.Olahraga, System.Data.DbType.String);
            dp.Add("@Organisasi", siswaRiwayat.Organisasi, System.Data.DbType.String);
            dp.Add("@Hobi", siswaRiwayat.Hobi, System.Data.DbType.String);
            dp.Add("@CitaCita", siswaRiwayat.CitaCita, System.Data.DbType.String);
            dp.Add("@TglTinggalSekolah", siswaRiwayat.TglTinggalSekolah, System.Data.DbType.Date);
            dp.Add("@AlasanTinggal", siswaRiwayat.AlasanTinggal, System.Data.DbType.String);
            dp.Add("@AkhirTamatBljr", siswaRiwayat.AkhirTamatBljr, System.Data.DbType.Date);
            dp.Add("@AkhirNoIjazah", siswaRiwayat.AkhirNoIjazah, System.Data.DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var update = koneksi.Execute(sql,dp);
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
