using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
