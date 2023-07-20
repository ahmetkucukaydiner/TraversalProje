using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Concrete;
using Traversal.DataAccess.EntityFramework;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
