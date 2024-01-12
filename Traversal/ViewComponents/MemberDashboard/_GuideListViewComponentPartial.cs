using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _GuideListViewComponentPartial : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
