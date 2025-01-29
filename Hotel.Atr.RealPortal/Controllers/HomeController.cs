using System.Diagnostics;
using Hotel.Atr.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr.RealPortal.Controllers
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

        public IActionResult Contact()
        {
            return View();
        }


    }
}
