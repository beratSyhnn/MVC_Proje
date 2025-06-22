using Microsoft.AspNetCore.Mvc;
using SporUyeTakipSistemi.Models;

namespace SporUyeTakipSistemi.Controllers
{
    public class UyeController : Controller
    {
       
        static List<Uye> uyeler = new List<Uye>();

       
        public ActionResult Kayit()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Kayit(Uye model)
        {
            uyeler.Add(model);
            return RedirectToAction("Listele");
        }

      
        public ActionResult Listele()
        {
            return View(uyeler);
        }
    }
}
