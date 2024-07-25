using CarsMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarsMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Model(string name, string year, string color)
        {
            CarModel model = new CarModel()
            {
                CarName = name,
                Year = year,
                Color = color
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
