using Dapper;
using SistemInformasiSekolah.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
{
    public class GuruDal
    {
        public IEnumerable<GuruModel> ListData()
        {
            const string sql = @"SELECT * FROM Guru";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<GuruModel>(sql);
        }
        public int Insert(GuruModel guru)
        {
            const string sql = @"
                            INSERT INTO Guru(
                                GuruName, TglLahir, JurusanPendidikan, 
                                TingkatPendidikan, TahunLulus, InstansiPendidikan, 
                                KotaPendidikan)
                            OUTPUT INSERTED.GuruId
                            VALUES(
                                @GuruName, @TglLahir, @JurusanPendidikan, 
                                @TingkatPendidikan, @TahunLulus, 
                                @InstansiPendidikan, @KotaPendidikan)";
            const string idAkhir = "SELECT MAX(GuruId) FROM Guru";
            var dp = new DynamicParameters();
            dp.Add("@GuruName", guru.GuruName, DbType.String);
            dp.Add("@TglLahir", guru.TglLahir, DbType.DateTime);
            dp.Add("@JurusanPendidikan", guru.JurusanPendidikan, DbType.String);
            dp.Add("@TingkatPendidikan", guru.TingkatPendidikan, DbType.String);
            dp.Add("@TahunLulus", guru.TahunLulus, DbType.String);
            dp.Add("@InstansiPendidikan", guru.InstansiPendidikan, DbType.String);
            dp.Add("@KotaPendidikan", guru.KotaPendidikan, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, dp);
            return koneksi.QuerySingle<int>(idAkhir);
        }

        public void Update(GuruModel guru)
        {
            const string sql = @"UPDATE Guru SET
                                    GuruName = @GuruName,
                                    TglLahir  = @TglLahir,
                                    JurusanPendidikan = @JurusanPendidikan,
                                    TingkatPendidikan  = @TingkatPendidikan,
                                    TahunLulus = @TahunLulus,
                                    InstansiPendidikan = @InstansiPendidikan,
                                    KotaPendidikan = @KotaPendidikan
                                WHERE
                                    GuruId=@GuruId";
            var dp = new DynamicParameters();
            dp.Add("@GuruId", guru.GuruId, DbType.Int32);
            dp.Add("@GuruName", guru.GuruName, DbType.String);
            dp.Add("@TglLahir", guru.TglLahir, DbType.DateTime);
            dp.Add("@JurusanPendidikan", guru.JurusanPendidikan, DbType.String);
            dp.Add("@TingkatPendidikan", guru.TingkatPendidikan, DbType.String);
            dp.Add("@TahunLulus", guru.TahunLulus, DbType.String);
            dp.Add("@InstansiPendidikan", guru.InstansiPendidikan, DbType.String);
            dp.Add("@KotaPendidikan", guru.KotaPendidikan, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, dp);
        }

        public void Delete(int guruId)
        {
            const string sql = @"DELETE FROM Guru WHERE GuruId=@GuruId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {GuruId=guruId});
        }

        public GuruModel? GetData(int guruId)
        {
            const string sql = @"SELECT * FROM Guru WHERE GuruId=@GuruId";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<GuruModel>(sql, new { GuruId = guruId });
        }
    }
}
