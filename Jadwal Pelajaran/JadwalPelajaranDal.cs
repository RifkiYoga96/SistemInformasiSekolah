using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Jadwal_Pelajaran
{
    public class JadwalPelajaranDal
    {
        public IEnumerable<JadwalPelajaranModel> ListData()
        {
            const string sql = @"SELECT * FROM JadwalPelajaran";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<JadwalPelajaranModel>(sql);
        }

        public JadwalPelajaranModel? GetData(int ID)
        {
            const string sql = @"SELECT * FROM JadwalPelajaran WHERE JadwalPelajaranId=@ID";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<JadwalPelajaranModel>(sql, new {ID=ID});
        }

        public void Delete(int ID)
        {
            const string sql = @"DELETE FFOM JadwalPelajaran WHERE JadwalPelajaranId=@ID";
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql, new {ID=ID});
        }

        public void Insert(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                                INSERT INTO JadwalPelajaran(
                                    KelasId,Hari,JenisJadwal,JamMulai,JamSelesai,
                                    MapelId,GuruId,Keterangan)
                                VALUES(
                                    @KelasId,@Hari,@JenisJadwal,@JamMulai,@JamSelesai,
                                    @MapelId,@GuruId,@Keterangan)";
            var dp = new DynamicParameters();
            dp.Add("@KelasId",jadwal.KelasId,System.Data.DbType.Int16);
            dp.Add("@Hari",jadwal.Hari,System.Data.DbType.String);
            dp.Add("@JenisJadwal",jadwal.JenisJadwal,System.Data.DbType.String);
            dp.Add("@JamMulai",jadwal.JamMulai,System.Data.DbType.String);
            dp.Add("@JamSelesai",jadwal.JamSelesai,System.Data.DbType.String);
            dp.Add("@MapelId",jadwal.MapelId,System.Data.DbType.Int16);
            dp.Add("@GuruId",jadwal.GuruId,System.Data.DbType.Int16);
            dp.Add("@Keterangan",jadwal.Keterangan,System.Data.DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
        }

        public void Update(JadwalPelajaranModel jadwal)
        {
            const string sql = @"
                                UPDATE JadwalPelajaran SET
                                    KelasId=@KelasId,Hari=@Hari,JenisJadwal=@JenisJadwal,
                                    JamMulai=@JamMulai,JamSelesai=@JamSelesai,
                                    MapelId=@MapelId,GuruId=@GuruId,Keterangan=@Keterangan
                                WHERE JadwalPelajaranId=@JadwalPelajaranId";
            var dp = new DynamicParameters();
            dp.Add("@JadwalPelajaranId", jadwal.JadwalPelajaranId, System.Data.DbType.Int16);
            dp.Add("@KelasId", jadwal.KelasId, System.Data.DbType.Int16);
            dp.Add("@Hari", jadwal.Hari, System.Data.DbType.String);
            dp.Add("@JenisJadwal", jadwal.JenisJadwal, System.Data.DbType.String);
            dp.Add("@JamMulai", jadwal.JamMulai, System.Data.DbType.String);
            dp.Add("@JamSelesai", jadwal.JamSelesai, System.Data.DbType.String);
            dp.Add("@MapelId", jadwal.MapelId, System.Data.DbType.Int16);
            dp.Add("@GuruId", jadwal.GuruId, System.Data.DbType.Int16);
            dp.Add("@Keterangan", jadwal.Keterangan, System.Data.DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
        }
    }
}
