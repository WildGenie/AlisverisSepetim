using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int KategoriId { get; set; }
    }
}
