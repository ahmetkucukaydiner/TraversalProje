using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.Name + ' ' + values.Surname;
            ViewBag.memberNumber = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;
            return View();
        }
    }
}