using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Concrete;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Cards1Statistics : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.TourCount = c.Destinations.Count();
            ViewBag.CustomerCount = c.Users.Count();
            return View();
        }
    }
}
