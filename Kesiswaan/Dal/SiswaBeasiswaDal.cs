using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Kesiswaan.Dal
{
    public class SiswaBeasiswaDal
    {
        public IEnumerable<SiswaBeasiswaModel> ListData(int siswaId)
        {
            const string sql = @"
                SELECT
                    *
                FROM
                    SiswaBeasiswa
                WHERE 
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId, System.Data.DbType.Int16);

            using var conn = new SqlConnection(DbDal.DB());
            return conn.Query<SiswaBeasiswaModel>(sql, dp);
        }

        public void Insert(IEnumerable<SiswaBeasiswaModel> listBeasiswa)
        {
            const string sql = @"
                INSERT INTO SiswaBeasiswa
                    (SiswaId, NoUrut, Tahun, Kelas, AsalBeasiswa)
                VALUES
                    (@SiswaId, @NoUrut, @Tahun, @Kelas, @AsalBeasiswa)";

            using var conn = new SqlConnection(DbDal.DB());
            foreach (var item in listBeasiswa)
            {
                var dp = new DynamicParameters();
                dp.Add("@SiswaId", item.SiswaId);
                dp.Add("@NoUrut", item.NoUrut);
                dp.Add("@Tahun", item.Tahun);
                dp.Add("@Kelas", item.Kelas);
                dp.Add("@AsalBeasiswa", item.AsalBeasiswa);

                conn.Execute(sql, dp);
            }
        }

        public void Delete(int siswaId)
        {
            const string sql = @"
                DELETE FROM 
                    SiswaBeasiswa
                WHERE
                    SiswaId = @SiswaId";

            var dp = new DynamicParameters();
            dp.Add("@SiswaId", siswaId);

            using var conn = new SqlConnection(DbDal.DB());
            conn.Execute(sql, dp);
        }
    }
}
