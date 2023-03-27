using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class BookingRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
