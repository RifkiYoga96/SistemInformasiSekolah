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
            return $"Server=(local);Database=SekolahKu;Trusted_Connection=True;TrustServerCertificate=True";
        }
    }
}
