using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    public class CommentController : Controller
    {
        [Area("Member")]
        [Route("Member/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
