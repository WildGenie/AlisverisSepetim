using AlisverisSepetim.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSepetim.Controllers
{
    public class SatisController : Controller
    {
        KategoriMemoryRepository kategoriRepository;
        UrunMemoryRepository urunRepository;
        public SatisController()
        {
            kategoriRepository = new KategoriMemoryRepository();
            urunRepository = new UrunMemoryRepository();
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

    }
}
