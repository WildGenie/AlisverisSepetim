using AlisverisSepetim.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Data
{
    public class SepetRepository
    {
        private AlisverisSepetimContext db;

        public SepetRepository(AlisverisSepetimContext db)
        {
            this.db = db;
        }

        public List<Sepet> SepetiGetir()
        {
            return db.Sepet.Include(s => s.Urun).ToList();
        }

        public void UrunEkle(int urunId, int adet)
        {
            var sepetUrunu = db.Sepet.FirstOrDefault(s => s.UrunId == urunId);
            if (sepetUrunu is null)
            {
                sepetUrunu = new Sepet
                {
                    UrunId = urunId,
                    Miktar = adet
                };
                db.Sepet.Add(sepetUrunu);
            }
            else
            {
                sepetUrunu.Miktar += adet;
            }

            db.SaveChanges();
        }

        public void UrunSil(int id)
        {
            db.Remove(db.Sepet.Single(s => s.Id == id));
            db.SaveChanges();
        }
    }
}
