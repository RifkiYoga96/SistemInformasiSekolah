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
    public class SiswaWaliDal
    {
        public int Insert(IEnumerable<SiswaWaliModel> siswaWalis)
        {
            const string sql = @"
                    INSERT INTO SiswaWali(
                        SiswaId, JenisWali, Nama, TmpLahir, TglLahir, Agama, 
                        Kewarga, Pendidikan, Pekerjaan, Penghasilan, Alamat, 
                        NoKK, NoTelp, StatusHidup, NIK)
                    VALUES (
                        @SiswaId, @JenisWali, @Nama, @TmpLahir, @TglLahir, @Agama, 
                        @Kewarga, @Pendidikan, @Pekerjaan, @Penghasilan, @Alamat, 
                        @NoKK, @NoTelp, @StatusHidup, @NIK)";
            int cek = 0;
            using var koneksi = new SqlConnection(DbDal.DB());
            foreach (var siswaWali in siswaWalis)
            {
                var dp = new DynamicParameters();
                dp.Add("@SiswaId", siswaWali.SiswaId, DbType.Int32);
                dp.Add("@JenisWali", siswaWali.JenisWali, DbType.String);
                dp.Add("@Nama", siswaWali.Nama, DbType.String);
                dp.Add("@TmpLahir", siswaWali.TmpLahir, DbType.String);
                dp.Add("@TglLahir", siswaWali.TglLahir, DbType.Date);
                dp.Add("@Agama", siswaWali.Agama, DbType.String);
                dp.Add("@Kewarga", siswaWali.Kewarga, DbType.String);
                dp.Add("@Pendidikan", siswaWali.Pendidikan, DbType.String);
                dp.Add("@Pekerjaan", siswaWali.Pekerjaan, DbType.String);
                dp.Add("@Penghasilan", siswaWali.Penghasilan, DbType.Decimal);
                dp.Add("@Alamat", siswaWali.Alamat, DbType.String);
                dp.Add("@NoKK", siswaWali.NoKK, DbType.String);
                dp.Add("@NoTelp", siswaWali.NoTelp, DbType.String);
                dp.Add("@StatusHidup", siswaWali.StatusHidup, DbType.String);
                dp.Add("@NIK", siswaWali.NIK, DbType.String);
                var insert = koneksi.Execute(sql,dp);
                if (insert > 0) cek++;
            }
            return cek;
        }

        public int Update(IEnumerable<SiswaWaliModel> siswaWalis)
        {

            const string sql = @"
                    UPDATE SiswaWali
                    SET
                        JenisWali = @JenisWali,
                        Nama = @Nama,
                        TmpLahir = @TmpLahir,
                        TglLahir = @TglLahir,
                        Agama = @Agama,
                        Kewarga = @Kewarga,
                        Pendidikan = @Pendidikan,
                        Pekerjaan = @Pekerjaan,
                        Penghasilan = @Penghasilan,
                        Alamat = @Alamat,
                        NoKK = @NoKK,
                        NoTelp = @NoTelp,
                        StatusHidup = @StatusHidup,
                        NIK = @NIK
                    WHERE SiswaId = @SiswaId";
            int cek = 0;
            using var koneksi = new SqlConnection(DbDal.DB());
            foreach (var siswaWali in siswaWalis)
            {
                var dp = new DynamicParameters();
                dp.Add("@SiswaId", siswaWali.SiswaId, DbType.Int32);
                dp.Add("@JenisWali", siswaWali.JenisWali, DbType.String);
                dp.Add("@Nama", siswaWali.Nama, DbType.String);
                dp.Add("@TmpLahir", siswaWali.TmpLahir, DbType.String);
                dp.Add("@TglLahir", siswaWali.TglLahir, DbType.Date);
                dp.Add("@Agama", siswaWali.Agama, DbType.String);
                dp.Add("@Kewarga", siswaWali.Kewarga, DbType.String);
                dp.Add("@Pendidikan", siswaWali.Pendidikan, DbType.String);
                dp.Add("@Pekerjaan", siswaWali.Pekerjaan, DbType.String);
                dp.Add("@Penghasilan", siswaWali.Penghasilan, DbType.Decimal);
                dp.Add("@Alamat", siswaWali.Alamat, DbType.String);
                dp.Add("@NoKK", siswaWali.NoKK, DbType.String);
                dp.Add("@NoTelp", siswaWali.NoTelp, DbType.String);
                dp.Add("@StatusHidup", siswaWali.StatusHidup, DbType.String);
                dp.Add("@NIK", siswaWali.NIK, DbType.String);

                var update = koneksi.Execute(sql,dp);
                if (update > 0) cek++;
            }
            return cek;
        }

        public SiswaWaliModel? GetData(int siswaId)
        {
            const string sql = @"SELECT * FROM SiswaWali WHERE SiswaId=@SiswaId";
            var dp = new DynamicParameters();
            dp.Add("@SiswaId",siswaId, DbType.Int16);
            var koneksi =  new SqlConnection(DbDal.DB());
            var get = koneksi.QueryFirstOrDefault(sql,dp);
            return get;
        }

        
    }
}
