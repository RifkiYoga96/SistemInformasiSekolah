using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah
{
    public class PersensiModel
    {
        public int PersensiId { get; set; }
        public DateTime Tgl { get; set; }
        public string Jam { get; set; }
        public int KelasId { get; set; }
        public string KelasName { get; set; }
        public int MapelId { get; set; }
        public string MapelName { get; set; }
        public int GuruId { get; set; }
        public string GuruName { get; set; }
        public List<PersensiDetailModel> ListPersensiDetail { get; set; }
    }
}
