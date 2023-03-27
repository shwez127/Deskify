using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class BookingSeatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
