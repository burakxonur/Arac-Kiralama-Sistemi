using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.UILayaoutViewComponent
{
    public class _HeadUILayaoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
