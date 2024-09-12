using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah.Model
{
    public class KelasModel
    {
        public int KelasId { get; set; }
        public string NamaKelas { get; set; }
        public int Tingkat {  get; set; }
        public int JurusanId {  get; set; }
        public string Flag {  get; set; }
    }
}
