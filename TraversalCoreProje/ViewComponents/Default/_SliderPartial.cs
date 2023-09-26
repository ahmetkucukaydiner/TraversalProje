using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            var destinations = c.Destinations.Select(d => d.City).ToList();
            return View(destinations);
        }
    }
}
