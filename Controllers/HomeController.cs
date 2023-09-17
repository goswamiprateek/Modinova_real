using Medinova.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Medinova.Controllers
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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
       public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        
        public IActionResult testimonial()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();

        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Contact()
        {
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