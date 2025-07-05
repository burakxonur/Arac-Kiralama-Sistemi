using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımızda";
            ViewBag.v2 = "Misyon ve Vizyon";
            return View();
        }
    }
}
