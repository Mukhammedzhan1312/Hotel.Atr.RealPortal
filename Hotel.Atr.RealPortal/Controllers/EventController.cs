using Hotel.Atr.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr.RealPortal.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            #region Get data from DataBase
            List<EventViewModel> events = new List<EventViewModel>();

            EventViewModel even = new EventViewModel();

            even.ImageSize = 2;
            even.PathImage = "~/img/event/1.jpg";
            even.EventTitle = "management conferences";
            even.AuthorName = "By : Jhtyg Hyuir";
            even.Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt";

            events.Add(even);

            #endregion
            return View(events);
        }
    }
}
