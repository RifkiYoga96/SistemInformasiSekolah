using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Kelas_Siswa
{
    public class KelasSiswaDal
    {
        public void Insert(KelasSiswaModel kelasSiswa)
        {
            const string sql = @"INSERT INTO KelasSiswa(KelasId,TahunAjaran,WaliKelasId)";
            var dp = new DynamicParameters();
            dp.Add("@KelasId",kelasSiswa.KelasId,System.Data.DbType.Int16);
            dp.Add("@TahunAjaran",kelasSiswa.TahunAjaran,System.Data.DbType.String);
            dp.Add("@WaliKelasId",kelasSiswa.WaliKelasId,System.Data.DbType.Int16);
            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
        }
        public void Update(KelasSiswaModel kelasSiswa)
        {
            const string sql = @"UPDATE KelasSiswa SET KelasId=@KelasId,TahunAjaran=@TahunAjaran,WaliKelasID=@WaliKelasId";
            var dp = new DynamicParameters();
            dp.Add("@KelasId", kelasSiswa.KelasId, System.Data.DbType.Int16);
            dp.Add("@TahunAjaran", kelasSiswa.TahunAjaran, System.Data.DbType.String);
            dp.Add("@WaliKelasId", kelasSiswa.WaliKelasId, System.Data.DbType.Int16);
            var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, dp);
        }
        public IEnumerable<KelasSiswaModel> ListData()
        {
            const string sql = @"SELECT ks.KelasId,k.KelasName,ks.TahunAjaran,ks.WaliKelasId,
                                        g.GuruName,ksd.SiswaName
                                 FROM KelasSiswa ks 
                                 INNER JOIN Kelas k ON ks.KelasId = k.KelasId
                                 INNER JOIN KelasSiswaDetail ksd ON k.KelasId=kld.KelasId";
            var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<KelasSiswaModel>(sql);
        }
    }
}
