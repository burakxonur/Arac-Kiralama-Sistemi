using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.AboutViewComponent
{
    public class _BecomeADriverComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
