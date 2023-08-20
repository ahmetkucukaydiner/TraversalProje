using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ApiExchangeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingExchange2ViewModel> bookingExchange2ViewModels = new List<BookingExchange2ViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://apidojo-booking-v1.p.rapidapi.com/currency/get-exchange-rates?base_currency=TRY&languagecode=tr-tr"),
                Headers =
                {
                    { "X-RapidAPI-Key", "6e4bfea790msh2e09ff016e6d832p120202jsn16e88afae84f" },
                    { "X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com" }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingExchange2ViewModel>(body);
                return View(values.exchange_rates);
            }
        }
    }
}
