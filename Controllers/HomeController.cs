using Microsoft.AspNetCore.Mvc;
using Ship_Review.Models;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;


namespace Ship_Review.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private string serviceUrl = "http://localhost:5000/ShipReview";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View();
            //HttpClient httpClient = new HttpClient();
            //using var response = httpClient.GetAsync(serviceUrl + "/" + id.Value).Result;

            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    string apiResponse = response.Content.ReadAsStringAsync().Result;
            //    ShipInfoAndEvaluation shipInfo = JsonSerializer.Deserialize<ShipInfoAndEvaluation>(apiResponse);
            //    return View(shipInfo);
            //}
            //else { return RedirectToAction("Error"); }
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(ShipInfoAndEvaluation shipInfo)
        {
            HttpClient httpClient = new HttpClient();
            string shipInfoString = JsonSerializer.Serialize<ShipInfoAndEvaluation>(shipInfo);
            StringContent content = new StringContent(shipInfoString, Encoding.UTF8, "application/json");
            using var response = httpClient.PostAsync(serviceUrl, content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            { return RedirectToAction("Index"); }
            else { return RedirectToAction("Error"); }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}