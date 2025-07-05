using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.CarDetailViewComponent
{
    public class _CarDetailTabPaneComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
