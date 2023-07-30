using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Traversal.Business.Concrete;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.EntityFramework;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
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
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.Id.ToString()
                                           }).ToList();

            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 5;
            reservation.Status = "Onay Bekliyor";
            reservationManager.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
