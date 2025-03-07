using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using RapidApiConsume.Models;
using System.Threading.Tasks;
using System.Windows.Markup;
using Newtonsoft.Json;
using System.Linq;

namespace RapidApiConsume.Controllers

{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<BookingApiViewModel> bookingApiViewModels = new List<BookingApiViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?include_adjacency=true&checkout_date=2025-06-17&dest_id=-1456925&units=metric&page_number=0&children_ages=5%2C0&room_number=1&filter_by_currency=EUR&checkin_date=2025-06-16&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&locale=en-gb&children_number=2&order_by=popularity&dest_type=city"),
                Headers =
    {
        { "x-rapidapi-key", "d25fea1d2emsha784d5dba56201bp1628e8jsn9ed1bab4b844" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                return View(values.results.ToList());

            }
            
        }
    }
}
