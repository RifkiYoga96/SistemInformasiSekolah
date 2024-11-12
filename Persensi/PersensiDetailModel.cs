using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah
{
    public class PersensiDetailModel
    {
        public int PersensiId {  get; set; }
        public int NoUrut { get; set; }
        public int SiswaId { get; set; }
        public string NamaLengkap { get; set; }
        public string StatusPersensi { get; set; }
        public string Keterangan {  get; set; }
    }
}
