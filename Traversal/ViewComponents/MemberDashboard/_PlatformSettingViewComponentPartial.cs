using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _PlatformSettingViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
