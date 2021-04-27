using AlisverisSepetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Data
{
    public class KategoriRepository
    {
        private AlisverisSepetimContext db;

        public KategoriRepository(AlisverisSepetimContext db)
        {
            this.db = db;
        }

        public List<Kategori> KategorileriGetir()
        {
            return db.Kategori.ToList();
        }

        public Kategori KategoriGetir(int Id)
        {
            return db.Kategori.FirstOrDefault(kategori => kategori.Id == Id);
        }
    }
}
