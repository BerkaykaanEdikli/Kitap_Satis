using Kitap_Satis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kitap_Satis.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            KitapModel kitap = new KitapModel();
            kitap.KitapId = 001;
            kitap.KitapAdi = "Hacı Murat";
            kitap.SayfaSayisi = 164;
            kitap.YazarAdi = "Fyodor Mihayloviç Dostayevski";
            kitap.KitapTuru = "Roman";
            ViewBag.Kitap = kitap;
            return View();
        }
    }
}
