using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Persensi
{
    public class PersensiDetailDal
    {

        public IEnumerable<PersensiDetailModel> ListData(int PersensiId)
        {
            const string sql = @"SELECT s.NamaLengkap, s.SiswaId, pd.NoUrut,
                                        pd.StatusPersensi, pd.Keterangan
                                 FROM PersensiDetail pd
                                      RIGHT JOIN Siswa s ON pd.SiswaId = s.SiswaId
                                 WHERE pd.PersensiId = @PersensiId";

            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<PersensiDetailModel>(sql, new {PersensiId=PersensiId});
        }
        public void Insert(IEnumerable<PersensiDetailModel> persensiDetail, int persensiId)
        {
            using var koneksi = new SqlConnection(DbDal.DB());
            foreach(var item in persensiDetail)
            {
                const string sql = @"INSERT INTO PersensiDetail(
                                                PersensiId,NoUrut,SiswaId,
                                                StatusPersensi,Keterangan)
                                 VALUES (@PersensiId,@NoUrut,@SiswaId,
                                                @StatusPersensi,@Keterangan)";
                var dp = new DynamicParameters();
                dp.Add("@PersensiId", persensiId, System.Data.DbType.Int32);
                dp.Add("@NoUrut", item.NoUrut, System.Data.DbType.Int16);
                dp.Add("@SiswaId", item.SiswaId, System.Data.DbType.Int32);
                dp.Add("@StatusPersensi", item.StatusPersensi, System.Data.DbType.String);
                dp.Add("@Keterangan", item.Keterangan, System.Data.DbType.String);
                koneksi.Execute(sql, dp);
            }
        }

        public void Update(PersensiDetailModel persensiDetail)
        {
            const string sql = @"UPDATE PersensiDetail SET PersensiId = @PersensiId, NoUrut=@NoUrut,
                                                           SiswaId=@SiswaId, StatusPersensi=@StatusPersensi,
                                                           Keterangan=@Keterangan";
            var dp = new DynamicParameters();
            dp.Add("@PersensiId", persensiDetail.PersensiId, System.Data.DbType.Int32);
            dp.Add("@NoUrut", persensiDetail.NoUrut, System.Data.DbType.Int16);
            dp.Add("@SiswaId", persensiDetail.SiswaId, System.Data.DbType.Int32);
            dp.Add("@StatusPersensi", persensiDetail.StatusPersensi, System.Data.DbType.String);
            dp.Add("@Keterangan", persensiDetail.Keterangan, System.Data.DbType.String);
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, dp);
        }

        public void Delete(int persensiId)
        {
            const string sql = @"DELETE FROM PersensiDetail WHERE PersensiId = @PersensiId";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {PersensiId=persensiId});
        }
    }
}
