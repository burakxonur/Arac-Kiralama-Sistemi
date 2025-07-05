using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.UILayaoutViewComponent
{
    public class _SriptUILayaoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
