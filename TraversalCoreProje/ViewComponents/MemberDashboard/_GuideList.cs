using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.EntityFramework;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        private GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
