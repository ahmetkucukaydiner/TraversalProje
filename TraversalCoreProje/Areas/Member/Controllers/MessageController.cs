using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
