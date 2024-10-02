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
    public class MapelDal
    {
        public IEnumerable<Model.MapelModel> ListData()
        {
            const string sql = @"SELECT * FROM Mapel";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<Model.MapelModel>(sql);
        }

        public MapelModel? GetData(int MapelId)
        {
            const string sql = @"SELECT * FROM Mapel WHERE MapelId = @MapelId";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<MapelModel>(sql, new {MapelId= MapelId});
        }

        public void Insert(string NamaMapel)
        {
            const string sql = @"INSERT INTO Mapel(NamaMapel) VALUES(@NamaMapel)";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new { NamaMapel = NamaMapel });
        }

        public void Update(int MapelId,string NamaMapel)
        {
            const string sql = @"UPDATE Mapel SET NamaMapel=@NamaMapel WHERE MapelId=@Id";
            using var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@Id",MapelId);
            dp.Add("@NamaMapel",NamaMapel);
            koneksi.Execute(sql, dp);
        }

        public void Delete(int mapelId)
        {
            const string sql = @"DELETE FROM Mapel WHERE MapelId=@MapelId";
            using var koneksi = new SqlConnection (DbDal.DB());
            koneksi.Execute(sql, new { MapelId = mapelId });
        }
    }
}
