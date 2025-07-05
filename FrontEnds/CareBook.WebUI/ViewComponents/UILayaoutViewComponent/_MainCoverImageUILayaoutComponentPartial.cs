using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.UILayaoutViewComponent
{
    public class _MainCoverImageUILayaoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
