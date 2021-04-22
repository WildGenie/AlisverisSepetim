using AlisverisSepetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Data
{
    public class UrunRepository
    {
        private List<Urun> urunler;

        public UrunRepository()
        {
            urunler = new List<Urun>
            {
                new Urun {Id=1, Ad="Supangle", KategoriId=3},
                new Urun {Id=2, Ad="Kazandibi", KategoriId=3},
                new Urun {Id=3, Ad="Tulumba Tatlısı", KategoriId=3},
                new Urun {Id=4, Ad="Revani", KategoriId=3},
                new Urun {Id=5, Ad="Yeşil Elma", KategoriId=2},
                new Urun {Id=6, Ad="Kırmızı Elma", KategoriId=2},
                new Urun {Id=7, Ad="Armut", KategoriId=2},
                new Urun {Id=8, Ad="Kıvırcık Marul", KategoriId=1},
                new Urun {Id=9, Ad="Limon", KategoriId=1},
                new Urun {Id=10, Ad="Dereotu", KategoriId=1},
                new Urun {Id=11, Ad="Yeşil Soğan", KategoriId=1}
            };
        }

        public List<Urun> UrunleriGetir()
        {
            return urunler;
        }

        public List<Urun> UrunleriKategoriyeGoreGetir(int kategoriId)
        {
            return urunler.Where(urun => urun.KategoriId==kategoriId).ToList();
        }
    }
}
