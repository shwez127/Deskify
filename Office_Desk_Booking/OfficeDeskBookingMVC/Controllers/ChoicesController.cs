using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class ChoicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
