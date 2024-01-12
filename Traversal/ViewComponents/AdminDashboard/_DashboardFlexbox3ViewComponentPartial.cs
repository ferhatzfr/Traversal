using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _DashboardFlexbox3ViewComponentPartial : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
