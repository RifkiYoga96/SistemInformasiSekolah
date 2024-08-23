using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah
{
    public class DbDal
    {
        public static string DB()
        {
            return $"Server=(local);Database=SekolahKu1;Trusted_Connection=True;TrustServerCertificate=True";
        }
        
            

        
/*        public IEnumerable<SiswaModel> ListSiswa()
        {
            string sql = @"SELECT * FROM Siswa";
            using var koneksi = new SqlConnection(connstr);
            var siswa = koneksi.Query<SiswaModel>(sql);
            return siswa;
        }  
        public IEnumerable<SiswaModel> ListSiswaRiwayat()
        {
            string sql = @"SELECT * FROM SiswaRiwayat";
            using var koneksi = new SqlConnection(connstr);
            var siswa = koneksi.Query<SiswaModel>(sql);
            return siswa;
        }

        public int TemplateIUD(string sql, object parameter)
        {
            using var koneksi = new SqlConnection(connstr);
            var data = koneksi.Execute(sql,parameter);
            return data;
        }*/
    }
}
