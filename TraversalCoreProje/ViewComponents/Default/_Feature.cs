using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.EntityFramework;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View();
        }
    }
}
