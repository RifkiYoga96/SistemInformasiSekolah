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
    public class GuruMapelDal
    {
        public IEnumerable<GuruMapelModel> ListData(int guruId)
        {
            const string sql = @"
                SELECT 
                    gm.GuruId, gm.MapelId,
                    ISNULL(m.NamaMapel, '') AS NamaMapel
                FROM 
                    GuruMapel gm
                    LEFT JOIN Mapel m ON gm.MapelId = m.MapelId
                WHERE
                    GuruId = @GuruId";

            var dp = new DynamicParameters();
            dp.Add("@GuruId", guruId);

            using var conn = new SqlConnection(DbDal.DB());
            return conn.Query<GuruMapelModel>(sql, dp).ToList();
        }
        public void Insert(IEnumerable<GuruMapelModel> listMapel, int id)
        {
            const string sql = @"
                INSERT INTO GuruMapel
                    (GuruId, MapelId)
                VALUES
                    (@GuruId, @MapelId)";

            using var conn = new SqlConnection(DbDal.DB());
            foreach (var item in listMapel)
            {
                var dp = new DynamicParameters();
                dp.Add("@GuruId", id);
                dp.Add("@MapelId", item.MapelId);

                conn.Execute(sql, dp);
            }
        }

        public void Delete(int guruId)
        {
            const string sql = @"
                DELETE FROM GuruMapel
                WHERE GuruId = @GuruId";

            var dp = new DynamicParameters();
            dp.Add("@GuruId", guruId);

            using var conn = new SqlConnection(DbDal.DB());
            conn.Execute(sql, dp);
        }
    }
}
