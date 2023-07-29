using Microsoft.AspNetCore.Mvc;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        [Area("Member")]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            return View();
        }
    }
}
