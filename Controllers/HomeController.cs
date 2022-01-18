using KOI_System.Context;
using KOI_System.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KOI_System.Controllers
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

        public IActionResult Default()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Event()
        {
            return View();
        }

        public IActionResult Location()
        {
            return View();
        }

        public IActionResult Record()
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