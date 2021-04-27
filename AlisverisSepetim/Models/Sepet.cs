using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Models
{
    public class Sepet
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public decimal Miktar { get; set; }
    }
}
