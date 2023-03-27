using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class ReservedSeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
