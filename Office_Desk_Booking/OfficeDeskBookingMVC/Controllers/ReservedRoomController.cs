using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class ReservedRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
