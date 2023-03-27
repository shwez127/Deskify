using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
