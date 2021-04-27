using AlisverisSepetim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Data
{
    public class UrunRepository
    {
        private AlisverisSepetimContext db;

        public UrunRepository(AlisverisSepetimContext db)
        {
            this.db = db;
        }

        public List<Urun> UrunleriGetir()
        {
            return db.Urun.ToList();
        }

        public List<Urun> UrunleriKategoriyeGoreGetir(int kategoriId)
        {
            return db.Urun.Where(urun => urun.KategoriId==kategoriId).ToList();
        }
    }
}
