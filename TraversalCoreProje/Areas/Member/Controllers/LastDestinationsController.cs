using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class LastDestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;

        public LastDestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
