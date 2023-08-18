using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Traversal.Business.Abstract;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(destination);
        }

        public IActionResult GetById(int id)
        {
            var value = _destinationService.TGetByID(id);
            if (value == null)
            {
                var errorMessage = "Aradığınız ID'ye ait veri bulunamadı.";
                return Json(new { error = errorMessage });
            }

            var jsonValue = JsonConvert.SerializeObject(value);
            return Json(jsonValue);
        }

        public IActionResult DeleteCity(int id)
        {
            var value = _destinationService.TGetByID(id);
            _destinationService.TDelete(value);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var jsonValue = JsonConvert.SerializeObject(destination);
            return Json(jsonValue);
        }

        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        Id = 1,
        //        CityName = "Üsküp",
        //        CityCountry = "Makedonya"
        //    },
        //    new CityClass
        //    {
        //        Id = 2,
        //        CityName = "Roma",
        //        CityCountry = "İtalya"
        //    },
        //    new CityClass
        //    {
        //        Id = 3,
        //        CityName = "Londra",
        //        CityCountry = "İngiltere"
        //    }
        //};
    }
}
