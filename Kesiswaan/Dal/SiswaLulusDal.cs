using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
{
    public class SiswaLulusDal
    {
        public int Insert(SiswaLulusModel siswaLulus)
        {
            const string sql = @"INSERT INTO SiswaLulus(
                                SiswaId,LanjutDi,TglMulaiKerja, NamaPerusahaan, Penghasilan)
                                VALUES(@SiswaId,@LanjutDi,@TglMulaiKerja, @NamaPerusahaan, @Penghasilan)";
            var dp = new DynamicParameters();
            dp.Add("@SiswaId",siswaLulus.SiswaId, System.Data.DbType.Int16);
            dp.Add("@LanjutDi",siswaLulus.LanjutDi, System.Data.DbType.String);
            dp.Add("@TglMulaiKerja",siswaLulus.TglMulaiKerja, System.Data.DbType.Date);
            dp.Add("@NamaPerusahaan",siswaLulus.NamaPerusahaan, System.Data.DbType.String);
            dp.Add("@Penghasilan",siswaLulus.Penghasilan, System.Data.DbType.Decimal);
            int cek = 0;
            using var koneksi = new SqlConnection(DbDal.DB());
            var insert = koneksi.Execute(sql,dp);
            if (insert > 0) cek++;
            return cek;
        }

        public int Update(SiswaLulusModel siswaLulus)
        {
            const string sql = @"UPDATE SiswaLulus SET 
                                             LanjutDi = @LanjutDi, 
                                             TglMulaiKerja = @TglMulaiKerja, 
                                             NamaPerusahaan = @NamaPerusahaan, 
                                             Penghasilan = @Penghasilan 
                                 WHERE SiswaId = @SiswaId";
            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaLulus.SiswaId, System.Data.DbType.Int16);
            dp.Add("@LanjutDi", siswaLulus.LanjutDi, System.Data.DbType.String);
            dp.Add("@TglMulaiKerja", siswaLulus.TglMulaiKerja, System.Data.DbType.Date);
            dp.Add("@NamaPerusahaan", siswaLulus.NamaPerusahaan, System.Data.DbType.String);
            dp.Add("@Penghasilan", siswaLulus.Penghasilan, System.Data.DbType.Decimal);
            int cek = 0;
            using var koneksi = new SqlConnection(DbDal.DB());
            var insert = koneksi.Execute(sql, dp);
            if (insert > 0) cek++;
            return cek;
        }

        public SiswaLulusModel? GetData(int siswaId)
        {
            const string sql = @"SELECT * FROM SiswaLulus WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            var get = koneksi.QueryFirstOrDefault<SiswaLulusModel>(sql, new {SiswaId=siswaId});
            return get;
        }

        public void Delete(int siswaId)
        {
            const string sql = @"DELETE FROM SiswaLulus WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {SiswaId=siswaId});
        }


    }
}
