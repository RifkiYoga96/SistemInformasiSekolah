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
                                NamaLengkap,NamaPanggil,Gender,TmpLahir,Agama
                                Kewarganegaraan,NIK,AnakKe,JmlhSdrKandung,JmlhSdrTiri,
                                JmlhSdrAngkat,YatimPiatu,Bahasa,Alamat,NoTelp,TngglDengan,
                                JrkKeSekolah,TransportSekolah)
                            OUTPUT INSERTED.SiswaId
                            VALUES(
                                 @NamaLengkap,@NamaPanggil,@Gender,@TmpLahir,@Agama,
                                 @Kemarganegaraan,@NIK,@AnakKe,@JmlhSdrKandung,@JmlhSdrTiri,
                                 @JmlhSdrAngkat,@YatimPiatu,@Bahasa,@Alamat,@NoTelp,@TngglDengan,
                                 @JrkKeSekolah,@TransportSekolah)";

            DynamicParameters param = new DynamicParameters();
            param.Add("@NamaLengkap",siswa.NamaLengkap, DbType.String);
            param.Add("@NamaPanggil",siswa.NamaPanggil, DbType.String);
            param.Add("@Gender",siswa.Gender, DbType.Int16);
            param.Add("@TmpLahir",siswa.TmpLahir, DbType.String);
            param.Add("@TglLahir",siswa.TglLahir, DbType.Date);
            param.Add("@Agama",siswa.Agama, DbType.String);
            param.Add("@Kewarganegaraan",siswa.Kewarganegaraan, DbType.String);
            param.Add("@NIK",siswa.NIK, DbType.String);
            param.Add("@AnakKe",siswa.TmpLahir, DbType.Int16);
            param.Add("@JmlhSdrKandung",siswa.JmlhSdrKandung, DbType.Int16);
            param.Add("@JmlhSdrAngkat",siswa.JmlhSdrAngkat, DbType.Int16);
            param.Add("@YatimPiatu",siswa.YatimPiatu, DbType.String);
            param.Add("@Bahasa",siswa.Bahasa, DbType.String);
            param.Add("@Alamat",siswa.Alamat, DbType.String);
            param.Add("@NoTelp",siswa.NoTelp, DbType.String);
            param.Add("@TngglDengan",siswa.TngglDengan, DbType.String);
            param.Add("@JrkKeSekolah",siswa.JrkKeSekolah, DbType.Int16);
            param.Add("@TransportSekolah",siswa.TransportSekolah, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var data = koneksi.Execute(sql,param);
            return data;
        }

        public void Update(SiswaModel siswa)
        {
            string sql = @"UPDATE Siswa SET
                                NamaLengkap=@NamaLengkap,NamaPanggil=@NamaPanggil,Gender=@Gender,
                                TmpLahir=@TmpLahir,Agama=@Agama,Kewarganegaraan=@Kewarganegaraan,
                                NIK=@NIK,AnakKe=@AnakKe,JmlhSdrkandung=@JmlhSdrKandung,
                                JmlhSdrTiri=@JmlhSdrTiri,JmlhSdrAngkat=@JmlhSdrAngkat,YatimPiatu=@YatimPiatu
                                ,Bahasa=@Bahasa,Alamat=@Alamat,NoTelp=@NoTelp,TngglDengan=@TngglDengan,
                                JrkKeSekolah=@JrkKeSekolah,TransportSekolah=@TransportSekolah
                            WHERE SiswaId=@SiswaId";
            DynamicParameters param = new DynamicParameters();
            param.Add("@NamaLengkap", siswa.NamaLengkap, DbType.String);
            param.Add("@NamaPanggil", siswa.NamaPanggil, DbType.String);
            param.Add("@Gender", siswa.Gender, DbType.Int16);
            param.Add("@TmpLahir", siswa.TmpLahir, DbType.String);
            param.Add("@TglLahir", siswa.TglLahir, DbType.Date);
            param.Add("@Agama", siswa.Agama, DbType.String);
            param.Add("@Kewarganegaraan", siswa.Kewarganegaraan, DbType.String);
            param.Add("@NIK", siswa.NIK, DbType.String);
            param.Add("@AnakKe", siswa.TmpLahir, DbType.Int16);
            param.Add("@JmlhSdrKandung", siswa.JmlhSdrKandung, DbType.Int16);
            param.Add("@JmlhSdrAngkat", siswa.JmlhSdrAngkat, DbType.Int16);
            param.Add("@YatimPiatu", siswa.YatimPiatu, DbType.String);
            param.Add("@Bahasa", siswa.Bahasa, DbType.String);
            param.Add("@Alamat", siswa.Alamat, DbType.String);
            param.Add("@NoTelp", siswa.NoTelp, DbType.String);
            param.Add("@TngglDengan", siswa.TngglDengan, DbType.String);
            param.Add("@JrkKeSekolah", siswa.JrkKeSekolah, DbType.Int16);
            param.Add("@TransportSekolah", siswa.TransportSekolah, DbType.String);

            using var koneksi = new SqlConnection(DbDal.DB());
            var data = koneksi.Execute(sql,param);
            if (data > 0) MessageBox.Show("Data Berhasil Di Update!");
        }

        public void Delete(SiswaModel siswa)
        {
            string sql = @"DELETE FROM Siswa WHERE SiswaId=@SiswaId";
            var dp = new DynamicParameters();
            DynamicParameters param = new DynamicParameters();
            dp.Add("@SiswaId",siswa.SiswaId, DbType.Int16);
            using var koneksi = new SqlConnection(DbDal.DB());
            var data = koneksi.Execute(sql,param);
        }

        public IEnumerable<SiswaModel> GetData(int SiswaId)
        {
            string sql = @"SELECT * FROM Siswa WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            var get = koneksi.QuerySingleOrDefault(sql, new {SiswaId=SiswaId});
            return get;
        } 
        public IEnumerable<SiswaModel> ListData(int SiswaId)
        {
            string sql = @"SELECT * FROM Siswa WHERE SiswaId=@SiswaId";
            using var koneksi = new SqlConnection(DbDal.DB());
            var listSiswa = koneksi.Query<SiswaModel>(sql, new {SiswaId=SiswaId});
            return listSiswa;
        }
    }
}
