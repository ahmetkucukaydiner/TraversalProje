using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.EntityFramework;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        private GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IActionResult Index()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
