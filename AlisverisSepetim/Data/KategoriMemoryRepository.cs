using AlisverisSepetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Data
{
    public class KategoriMemoryRepository
    {
        List<Kategori> kategoriler;
        public KategoriMemoryRepository()
        {
            kategoriler = new List<Kategori>
            {
                new Kategori{Id = 1, Adi = "Sebze"},
                new Kategori{Id = 2, Adi = "Meyve"},
                new Kategori{Id = 3, Adi = "Tatlı"},
                new Kategori{Id = 4, Adi = "Fast Food"}
            };
        }

        public List<Kategori> KategorileriGetir()
        {
            return kategoriler;
        }

        public Kategori KategoriGetir(int Id)
        {
            return kategoriler.FirstOrDefault(kategori => kategori.Id == Id);
        }
    }
}
