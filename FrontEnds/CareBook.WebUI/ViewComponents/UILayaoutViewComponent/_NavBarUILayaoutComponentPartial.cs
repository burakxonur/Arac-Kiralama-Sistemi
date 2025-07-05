using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.UILayaoutViewComponent
{
    public class _NavBarUILayaoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
