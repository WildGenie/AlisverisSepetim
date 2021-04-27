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
        public Kategori Kategori { get; set; }
        public double BirimFiyat { get; set; }
        //List<Kampanya> Kampanyalar {get;set;}
    }
}
// record Kampanya(int Id, string Adi, string Aciklama, int KampanyaTuru, double Oran)