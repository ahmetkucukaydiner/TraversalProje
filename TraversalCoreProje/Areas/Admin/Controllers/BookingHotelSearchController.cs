using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers;

[Area("Admin")]
[AllowAnonymous]

public class BookingHotelSearchController : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://apidojo-booking-v1.p.rapidapi.com/properties/list?offset=0&arrival_date=2024-01-15&departure_date=2024-01-20&guest_qty=1&dest_ids=-1456928&room_qty=1&search_type=city&children_qty=2&children_age=5%2C7&search_id=none&price_filter_currencycode=USD&order_by=popularity&languagecode=en-us&travel_purpose=leisure"),
            Headers =
            {
                { "X-RapidAPI-Key", "6e4bfea790msh2e09ff016e6d832p120202jsn16e88afae84f" },
                { "X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var bodyReplace = body.Replace(".0", "");
            var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
            return View(values.result);
        }
    }

    [HttpGet]
    public IActionResult GetCityDestinationId()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetCityDestinationId(string city)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://apidojo-booking-v1.p.rapidapi.com/locations/auto-complete?text={city}&languagecode=en-us"),
            Headers =
            {
                { "X-RapidAPI-Key", "6e4bfea790msh2e09ff016e6d832p120202jsn16e88afae84f" },
                { "X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            return View();
        }
    }
}

