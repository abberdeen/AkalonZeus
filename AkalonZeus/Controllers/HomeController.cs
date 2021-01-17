using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AkalonZeus.Models; 
using OpenWeatherMapClient.Models.Base;

namespace AkalonZeus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var apiKey = "68247420ccab2971c4ef714b3cdefe68";
            var oneCallApi = new OpenWeatherMapClient.OneCallRequest(apiKey);
            oneCallApi.GetCurrentAndForecastWeatherRawJson(new Coordinates(1, 2));

            return View();
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
