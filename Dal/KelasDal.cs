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
            const string sql = @"INSERT INTO Kelas(NamaKelas,Tingkat)
                                    VALUES(@NamaKelas,@Tingkat)";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@NamaKelas",kelas.NamaKelas,System.Data.DbType.String);
            dp.Add("@Tingkat",kelas.Tingkat,System.Data.DbType.Int32);
            koneksi.Execute(sql, dp);
        }

        public void Update(int MapelId, string NamaMapel)
        {
            const string sql = @"UPDATE Mapel SET NamaMapel=@NamaMapel WHERE MapelId=@Id";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@Id", MapelId);
            dp.Add("@NamaMapel", NamaMapel);
            koneksi.Execute(sql, dp);
        }

        public void Delete(int mapelId)
        {
            const string sql = @"DELETE FROM Mapel WHERE MapelId=@MapelId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new { MapelId = mapelId });
        }
    }
}
