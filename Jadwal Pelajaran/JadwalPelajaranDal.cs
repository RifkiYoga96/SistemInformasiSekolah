using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Jadwal_Pelajaran
{
    public class JadwalPelajaranDal
    {
        public IEnumerable<JadwalPelajaranModel> ListData(int KelasId, string JenisJadwal)
        {
            const string sql = @"SELECT 
                                       jp.JadwalPelajaranId,jp.KelasId,jp.Hari,jp.JenisJadwal,jp.JamMulai,
                                       jp.JamSelesai,jp.MapelId,jp.GuruId,k.NamaKelas,
                                       m.NamaMapel,g.GuruName
                                FROM JadwalPelajaran jp
                                    INNER JOIN Kelas k ON jp.KelasId=k.KelasId
                                    INNER JOIN Mapel m ON jp.MapelId=m.MapelId
                                    INNER JOIN Guru g ON jp.GuruId=g.GuruId
                                WHERE jp.KelasId=@KelasId AND jp.JenisJadwal=@JenisJadwal
                                ORDER BY 
                                    CASE
                                        WHEN jp.Hari = 'Senin' THEN 1
                                        WHEN jp.Hari = 'Selasa' THEN 2
                                        WHEN jp.Hari = 'Rabu' THEN 3
                                        WHEN jp.Hari = 'Kamis' THEN 4
                                        WHEN jp.Hari = 'Jum`at' THEN 5
                                        ELSE 6
                                    END,
                                    CAST(jp.JamMulai AS TIME)";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.Query<JadwalPelajaranModel>(sql, new {KelasId=KelasId,JenisJadwal=JenisJadwal});
        }

        public JadwalPelajaranModel? GetData(int ID)
        {
            const string sql = @"SELECT * FROM JadwalPelajaran WHERE JadwalPelajaranId=@ID";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<JadwalPelajaranModel>(sql, new {ID=ID});
        }

        public JadwalPelajaranModel? GetDataFirst(string sqlc,string NamaKelas)
        {
            string sql = $@"SELECT KelasId,NamaKelas FROM Kelas {sqlc}";
            using var koneksi = new SqlConnection(DbDal.DB());
            return koneksi.QueryFirstOrDefault<JadwalPelajaranModel>(sql, new {NamaKelas=NamaKelas});
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
