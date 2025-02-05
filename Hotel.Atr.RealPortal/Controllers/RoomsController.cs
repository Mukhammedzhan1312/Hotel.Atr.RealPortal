using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr.RealPortal.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
