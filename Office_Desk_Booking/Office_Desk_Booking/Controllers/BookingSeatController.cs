using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeDeskBLL.Services;
using OfficeDeskEntity.Models;

namespace OfficeDeskBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingSeatController : ControllerBase
    {
        private BookingSeatService _bookingService;

        public BookingSeatController(BookingSeatService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("AddSeat")]

        public IActionResult AddSeat(BookingSeat seat)
        {
            _bookingService.AddSeat(seat);
            return Ok("Seat Added Successfully");

        }

        [HttpDelete("DeleteSeat")]
        public IActionResult DeleteSeat(int seatId)
        {
            _bookingService.DeleteSeat(seatId);
            return Ok("Seat Deleted Successfully");
        }

        [HttpPut("UpdateSeat")]
        public IActionResult UpdateSeat(BookingSeat seat)
        {
            _bookingService.UpdateSeat(seat);
            return Ok("Seat Updated Successfully");
        }

        [HttpGet("GetAllSeat")]

        public IEnumerable<BookingSeat> GetAllSeat()
        {
            return _bookingService.GetAllSeat();
        }
        [HttpGet("GetSeatById")]
        public BookingSeat GetSeatById(int seatId)
        {
            return _bookingService.GetSeatById(seatId);
        }
    }
}
