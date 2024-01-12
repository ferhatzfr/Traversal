using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _DashboardFlexboxViewComponentPartial : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
