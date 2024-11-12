using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah
{
    public class PersensiDal
    {
        public PersensiModel? GetData(int KelasId, DateTime Tgl, string Jam)
        {
            const string sql = @"SELECT p.PersensiId,p.Tgl,p.Jam,k.KelasId,
                                        k.NamaKelas, m.MapelId,m.NamaMapel,
                                        g.GuruId, g.GuruName
                                FROM Persensi p
                                        INNER JOIN Kelas k ON p.KelasId = k.KelasId
                                        INNER JOIN Mapel m ON m.MapelId = p.MapelId
                                        INNER JOIN Guru g ON p.GuruId = g.GuruId
                                WHERE 
                                        k.KelasId = @KelasId AND p.Tgl = @Tgl AND p.Jam = @Jam";
            var dp = new DynamicParameters();
            dp.Add("@KelasId",KelasId, System.Data.DbType.Int16);
            dp.Add("@Tgl",Tgl, System.Data.DbType.DateTime);
            dp.Add("@Jam",Jam, System.Data.DbType.String);

            var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<PersensiModel>(sql,dp);
        }
        public int Insert(PersensiModel persensi)
        {
            const string sql = @"INSERT INTO Persensi(Tgl,Jam,KelasId,MapelId,GuruId)
                                OUTPUT INSERTED.PersensiId
                                VALUES (@Tgl,@Jam,@KelasId,@MapelId,@GuruId)";
            var dp = new DynamicParameters();
            dp.Add("@Tgl",persensi.Tgl, System.Data.DbType.Date);
            dp.Add("@Jam",persensi.Jam, System.Data.DbType.String);
            dp.Add("@KelasId",persensi.KelasId, System.Data.DbType.Int16);
            dp.Add("@MapelId",persensi.MapelId, System.Data.DbType.Int32);
            dp.Add("@GuruId",persensi.GuruId, System.Data.DbType.Int32);

            var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QuerySingle<int>(sql, dp);
        }

        public void Update(PersensiModel persensi)
        {
            const string sql = @"UPDATE Persensi SET(
                                    Tgl = @Tgl, Jam = @Jam, KelasId=@KelasId,
                                    MapelId= @MapelId, GuruId=@GuruId";
            var dp = new DynamicParameters();
            dp.Add("@Tgl", persensi.Tgl, System.Data.DbType.Date);
            dp.Add("@Jam", persensi.Jam, System.Data.DbType.Time);
            dp.Add("@KelasId", persensi.KelasId, System.Data.DbType.Int16);
            dp.Add("@MapelId", persensi.MapelId, System.Data.DbType.Int32);
            dp.Add("@GuruId", persensi.GuruId, System.Data.DbType.Int32);

            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
        }

        public void Delete(int PersensiId)
        {
            const string sql = @"DELETE Persensi WHERE PersensiId=@PersensiId";
            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {PersensiId=PersensiId});
        }
    }
}
