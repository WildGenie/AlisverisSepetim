using AlisverisSepetim.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Controllers
{
    public class SatisController : Controller
    {
        KategoriRepository kategoriRepository;
        UrunRepository urunRepository;
        SepetRepository sepetRepository;

        public SatisController(AlisverisSepetimContext db)
        {
            kategoriRepository = new KategoriRepository(db);
            urunRepository = new UrunRepository(db);
            sepetRepository = new SepetRepository(db);
        }
        public IActionResult Urunler(int? kategoriId)
        {

            List<Models.Urun> model;
            if (kategoriId.HasValue)
            {
                ViewData["filtre"] = kategoriRepository.KategoriGetir(kategoriId.Value)?.Adi;
                model = urunRepository.UrunleriKategoriyeGoreGetir(kategoriId.Value);
            }
            else
            {
                model = urunRepository.UrunleriGetir();
            }

            return base.View(model);
        }

        public IActionResult Kategoriler()
        {

            List<Models.Kategori> kategoriler = kategoriRepository.KategorileriGetir();
            return View(kategoriler);
        }

        public IActionResult Sepet()
        {
            List<Models.Sepet> sepet = sepetRepository.SepetiGetir();
            return View(sepet);
        }

        public IActionResult SepeteUrunEkle(int urunId)
        {
            sepetRepository.UrunEkle(urunId, 1);
            TempData["Bilgi"] = "Sepete Ürün Eklendi";
            return Redirect(Request.GetTypedHeaders().Referer.ToString());
        }
        public IActionResult SepettenUrunSil(int id)
        {
            sepetRepository.UrunSil(id);
            TempData["Bilgi"] = "Sepetten Ürün Silindi";
            return Redirect(Request.GetTypedHeaders().Referer.ToString());
        }
    }
}
