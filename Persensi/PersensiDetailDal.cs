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
        public void Insert(PersensiDetailModel persensiDetail)
        {
            const string sql = @"INSERT INTO PersensiDetail(
                                                PersensiId,NoUrut,SiswaId,
                                                StatusPersensi,Keterangan)
                                 VALUES (@PersensiId,@NoUrut,@SiswaId,
                                                @StatusPersensi,@Keterangan)";
            var dp = new DynamicParameters();
            dp.Add("@PersensiId",persensiDetail.PersensiId,System.Data.DbType.Int32);
            dp.Add("@NoUrut",persensiDetail.NoUrut,System.Data.DbType.Int16);
            dp.Add("@SiswaId",persensiDetail.SiswaId,System.Data.DbType.Int32);
            dp.Add("@StatusPersensi",persensiDetail.StatusPersensi,System.Data.DbType.String);
            dp.Add("@Keterangan",persensiDetail.Keterangan,System.Data.DbType.String);
            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
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
            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, dp);
        }
    }
}
