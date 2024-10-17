using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Kelas_Siswa
{
    public class KelasSiswaDetailDal
    {
        public void Insert(KelasSiswaDetailModel ksd)
        {
            const string sql = @"INSERT INTO KelasSiswaDetail(KelasId,SiswaId)
                                 VALUES(@KelasId,@SiswaId)";
            var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@KelasId",ksd.KelasId, System.Data.DbType.Int16);
            dp.Add("@SiswaId",ksd.SiswaId, System.Data.DbType.Int32);
            koneksi.Execute(sql,dp);
        }
        public void Update(KelasSiswaDetailModel ksd)
        {
            const string sql = @"UPDATE KelasSiswaDetail SET KelasId=@KelasId,SiswaId=@SiswaId";
            var koneksi = new SqlConnection(DbDal.DB());
            var dp = new DynamicParameters();
            dp.Add("@KelasId", ksd.KelasId, System.Data.DbType.Int16);
            dp.Add("@SiswaId", ksd.SiswaId, System.Data.DbType.Int32);
            koneksi.Execute(sql, dp);
        }
    }
}
