﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemInformasiSekolah
{
    public class KelasSiswaModel
    {
        public int KelasId { get; set; }
        public string NamaKelas { get; set; }
        public string TahunAjaran {  get; set; }
        public int WaliKelasId { get; set; }
        public string WaliKelasName { get; set; }
        public List<KelasSiswaModel> ListKelasSiswa { get; set; }
    }
}
