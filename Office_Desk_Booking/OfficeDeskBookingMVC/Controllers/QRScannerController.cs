using Microsoft.AspNetCore.Mvc;

namespace OfficeDeskBookingMVC.Controllers
{
    public class QRScannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
