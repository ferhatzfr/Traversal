using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Dafault
{
    public class _SliderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
