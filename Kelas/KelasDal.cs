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
    public class KelasDal
    {
        public IEnumerable<KelasModel> ListData()
        {
            const string sql = @"SELECT * FROM kelas";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<KelasModel>(sql);
        }

        public KelasModel? GetData(int KelasId)
        {
            const string sql = @"SELECT * FROM Kelas WHERE KelasId = @KelasId";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<KelasModel>(sql, new { KelasId = KelasId });
        }

        public void Insert(KelasModel kelas)
        {
            const string sql = @"INSERT INTO Kelas(NamaKelas,Tingkat,JurusanId,Flag)
                                    VALUES(@NamaKelas,@Tingkat,@JurusanId,@Flag)";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@NamaKelas",kelas.NamaKelas,System.Data.DbType.String);
            dp.Add("@Tingkat",kelas.Tingkat,System.Data.DbType.Int32);
            dp.Add("@JurusanId",kelas.JurusanId,System.Data.DbType.Int32);
            dp.Add("@Flag",kelas.Flag,System.Data.DbType.String);
            koneksi.Execute(sql, dp);
        }

        public void Update(KelasModel kelas)
        {
            const string sql = @"UPDATE Kelas SET NamaKelas=@NamaKelas,Tingkat=@Tingkat,
                                    JurusanId=@JurusanId,Flag=@Flag
                                 WHERE KelasId=@KelasId";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelas.KelasId, System.Data.DbType.Int32);
            dp.Add("@NamaKelas", kelas.NamaKelas, System.Data.DbType.String);
            dp.Add("@Tingkat", kelas.Tingkat, System.Data.DbType.Int32);
            dp.Add("@JurusanId", kelas.JurusanId, System.Data.DbType.Int32);
            dp.Add("@Flag", kelas.Flag, System.Data.DbType.String);
            koneksi.Execute(sql, dp);
        }

        public void Delete(int kelasId)
        {
            const string sql = @"DELETE FROM Kelas WHERE KelasId=@KelasId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new { KelasId = kelasId });
        }
    }
}
