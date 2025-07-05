using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarFilterComponentPartial:ViewComponent
    {
        public  IViewComponentResult Invoke(string v)
        {
            v = "aaaaa";
            TempData["value"] = v;
            return View();
        }
    }
}
