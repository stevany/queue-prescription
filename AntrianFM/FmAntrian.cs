using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antrianFM
{
    public class FmAntrian
    {
        
        [Key]
        public int AntrianId { get; set; }
        public string Nomor { get; set; }
        public int lantai { get; set; }
        public DateTime TglInsert { get; set; }
        public bool Racikan { get; set; }
        public bool Ambil{ get; set; }
        public bool Play { get; set; }
        public DateTime TglUpdate { get; set; }
        public string UsrInsert { get; set; }
        public string UsrUpdate { get; set; }
        
    }

}
