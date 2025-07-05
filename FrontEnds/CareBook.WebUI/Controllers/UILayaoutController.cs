using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.Controllers
{
    public class UILayaoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
