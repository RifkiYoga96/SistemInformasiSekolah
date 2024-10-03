using Dapper;
using SistemInformasiSekolah.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
{
    public class JurusanDal
    {
        public IEnumerable<JurusanModel> ListData()
        {
            const string sql = @"SELECT * FROM Jurusan";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<JurusanModel>(sql);
        }

        public JurusanModel? GetData(int JurusanId)
        {
            const string sql = @"SELECT * FROM Jurusan WHERE JurusanId = @JurusanId";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<JurusanModel>(sql, new { JurusanId = JurusanId });
        }

        public void Insert(string NamaJurusan, string code)
        {
            const string sql = @"INSERT INTO Jurusan(NamaJurusan,Code) VALUES(@NamaJurusan,@Code)";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new { NamaJurusan = NamaJurusan,Code = code });
        }

        public void Update(int jurusanId, string namaJurusan, string code)
        {
            const string sql = @"UPDATE Jurusan SET NamaJurusan=@NamaJurusan, Code = @Code WHERE JurusanId=Jurusan@Id";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@JurusanId", jurusanId, System.Data.DbType.Int32);
            dp.Add("@NamaJurusan", namaJurusan, System.Data.DbType.String);
            dp.Add("@Code", code, System.Data.DbType.String);
            koneksi.Execute(sql, dp);
        }

        public void Delete(int jurusanId)
        {
            const string sql = @"DELETE FROM Jurusan WHERE JurusanId=@JurusanId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {JurusanId=jurusanId});
        }
    }
}
