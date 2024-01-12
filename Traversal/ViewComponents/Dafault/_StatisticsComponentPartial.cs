using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Dafault
{
    public class _StatisticsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "200";
            return View();
        }
    }
}
