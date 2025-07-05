using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebUI.ViewComponents.CommentViewComponent
{
    public class _AddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
