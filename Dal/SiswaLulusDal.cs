using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Dal
{
    public class SiswaLulusDal
    {
        public int Insert(SiswaLulusModel siswaLulus)
        {
            const string sql = @"INSERT INTO SiswaLulus(
                                SiswaId,LanjutDi,TglMulaiBekerja, NamaPerusahaan, Penghasilan)
                                VALUES";
        }
    }
}
