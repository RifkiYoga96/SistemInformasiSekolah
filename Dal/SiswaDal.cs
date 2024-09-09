using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
{
    public class SiswaDal
    {
       
        public int Insert(SiswaModel siswa)
        {
            string sql = @"INSERT INTO Siswa(
                                NamaLengkap,NamaPanggil,Gender,TmpLahir,TglLahir,Agama,
                                Kewarganegaraan,NIK,AnakKe,JmlhSdrKandung,JmlhSdrTiri,
                                JmlhSdrAngkat,YatimPiatu,Bahasa,Alamat,NoTelp,TngglDengan,
                                JrkKeSekolah,TransportSekolah, LokasiPhoto)
                            OUTPUT INSERTED.SiswaId
                            VALUES(
                                 @NamaLengkap,@NamaPanggil,@Gender,@TmpLahir,@TglLahir,@Agama,
                                 @Kewarganegaraan,@NIK,@AnakKe,@JmlhSdrKandung,@JmlhSdrTiri,
                                 @JmlhSdrAngkat,@YatimPiatu,@Bahasa,@Alamat,@NoTelp,@TngglDengan,
                                 @JrkKeSekolah,@TransportSekolah,@LokasiPhoto)";

            var param = new DynamicParameters();
            param.Add("@NamaLengkap",siswa.NamaLengkap, DbType.String);
            param.Add("@NamaPanggil",siswa.NamaPanggil, DbType.String);
            param.Add("@Gender",siswa.Gender, DbType.Int16);
            param.Add("@TmpLahir",siswa.TmpLahir, DbType.String);
            param.Add("@TglLahir",siswa.TglLahir, DbType.DateTime);
            param.Add("@Agama",siswa.Agama, DbType.String);
            param.Add("@Kewarganegaraan",siswa.Kewarganegaraan, DbType.String);
            param.Add("@NIK",siswa.NIK, DbType.String);
            param.Add("@AnakKe",siswa.AnakKe, DbType.Int16);
            param.Add("@JmlhSdrKandung",siswa.JmlhSdrKandung, DbType.Int16);
            param.Add("@JmlhSdrTiri",siswa.JmlhSdrTiri, DbType.Int16);
            param.Add("@JmlhSdrAngkat",siswa.JmlhSdrAngkat, DbType.Int16);
            param.Add("@YatimPiatu",siswa.YatimPiatu, DbType.String);
            param.Add("@Bahasa",siswa.Bahasa, DbType.String);
            param.Add("@Alamat",siswa.Alamat, DbType.String);
            param.Add("@NoTelp",siswa.NoTelp, DbType.String);
            param.Add("@TngglDengan",siswa.TngglDengan, DbType.String);
            param.Add("@JrkKeSekolah",siswa.JrkKeSekolah, DbType.Int16);
            param.Add("@TransportSekolah",siswa.TransportSekolah, DbType.String);
            param.Add("@LokasiPhoto",siswa.LokasiPhoto?? string.Empty, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var data = koneksi.QuerySingle<int>(sql,param);
            return data;
        }

        public int Update(SiswaModel siswa)
        {
            string sql = @"UPDATE Siswa SET
                                NamaLengkap=@NamaLengkap,NamaPanggil=@NamaPanggil,Gender=@Gender,
                                TmpLahir=@TmpLahir,Agama=@Agama,Kewarganegaraan=@Kewarganegaraan,
                                NIK=@NIK,AnakKe=@AnakKe,JmlhSdrkandung=@JmlhSdrKandung,
                                JmlhSdrTiri=@JmlhSdrTiri,JmlhSdrAngkat=@JmlhSdrAngkat,YatimPiatu=@YatimPiatu
                                ,Bahasa=@Bahasa,Alamat=@Alamat,NoTelp=@NoTelp,TngglDengan=@TngglDengan,
                                JrkKeSekolah=@JrkKeSekolah,TransportSekolah=@TransportSekolah,LokasiPhoto=@LokasiPhoto
                            WHERE SiswaId=@SiswaId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@SiswaId", siswa.SiswaId, DbType.Int16);
            param.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            param.Add("@NamaPanggil", siswa.NamaPanggil, DbType.String);
            param.Add("@Gender", siswa.Gender, DbType.Int16);
            param.Add("@TmpLahir", siswa.TmpLahir, DbType.String);
            param.Add("@TglLahir", siswa.TglLahir, DbType.Date);
            param.Add("@Agama", siswa.Agama, DbType.String);
            param.Add("@Kewarganegaraan", siswa.Kewarganegaraan, DbType.String);
            param.Add("@NIK", siswa.NIK, DbType.String);
            param.Add("@AnakKe", siswa.AnakKe, DbType.Int16);
            param.Add("@JmlhSdrKandung", siswa.JmlhSdrKandung, DbType.Int16);
            param.Add("@JmlhSdrTiri", siswa.JmlhSdrTiri, DbType.Int16);
            param.Add("@JmlhSdrAngkat", siswa.JmlhSdrAngkat, DbType.Int16);
            param.Add("@YatimPiatu", siswa.YatimPiatu, DbType.String);
            param.Add("@Bahasa", siswa.Bahasa, DbType.String);
            param.Add("@Alamat", siswa.Alamat, DbType.String);
            param.Add("@NoTelp", siswa.NoTelp, DbType.String);
            param.Add("@TngglDengan", siswa.TngglDengan, DbType.String);
            param.Add("@JrkKeSekolah", siswa.JrkKeSekolah, DbType.Int16);
            param.Add("@TransportSekolah", siswa.TransportSekolah, DbType.String);
            param.Add("@LokasiPhoto", siswa.LokasiPhoto, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var data = koneksi.Execute(sql,param);
            return data;
        }

        public void DeletePhoto(int siswaId)
        {
            const string sql = @"UPDATE Siswa SET LokasiPhoto ='' WHERE SiswaId=@SiswaId";
            using var conn = new SqlConnection(DbDal.DB());
            conn.Execute(sql, new {SiswaId = siswaId});
        }

        public void Delete(int siswaId)
        {
            const string sql = @"DELETE FROM Siswa WHERE SiswaId=@SiswaId";
            var dp = new DynamicParameters();
            dp.Add("@SiswaId",siswaId,DbType.Int16);
            using var koneksi = new SqlConnection(DbDal.DB());
            koneksi.Execute(sql,dp);
        }

        public SiswaModel? GetData(int SiswaId)
        {
            string sql = @"SELECT * FROM Siswa WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            var get = koneksi.QuerySingleOrDefault<SiswaModel>(sql, new {SiswaId=SiswaId});
            return get;
        } 
        public IEnumerable<SiswaModel> ListData()
        {
            string sql = @"SELECT * FROM Siswa";
            using var koneksi = new SqlConnection(DbDal.DB());
            var listSiswa = koneksi.Query<SiswaModel>(sql);
            return listSiswa;
        }
    }
}
