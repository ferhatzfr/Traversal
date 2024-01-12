using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _ProfileInformationViewComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformationViewComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.UserName + " " + values.SurName;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;
            return View();
        }
    }
}
