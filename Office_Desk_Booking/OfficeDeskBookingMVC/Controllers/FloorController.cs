using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class FloorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
