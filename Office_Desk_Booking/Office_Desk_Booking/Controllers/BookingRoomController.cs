using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeDeskBLL.Services;
using OfficeDeskEntity.Models;

namespace OfficeDeskBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingRoomController : ControllerBase
    {
        private BookingRoomService _bookingRoomService; 
        public BookingRoomController(BookingRoomService bookingRoomService)
        {
            _bookingRoomService = bookingRoomService;
        }
        #region GET ROOMS
        [HttpGet("GetRooms")]
        public IEnumerable<BookingRoom> GetRooms()
        {
            return _bookingRoomService.GetRoom();
        }
        #endregion     
        #region ROOMBYID
        [HttpGet("GetRoomById")]
        public BookingRoom GetBookingRoomById(int roomId)
        {
            return _bookingRoomService.GetRoomById(roomId);
        }
#endregion     
        #region ADD ROOM
        [HttpPost("AddRoom")]
        public IActionResult GetBookingRoom([FromBody] BookingRoom room)
        {
            _bookingRoomService.AddRoom(room);
            return Ok("Room added successfully");
        }
#endregion       
        #region DELETE ROOM
        [HttpDelete("DeleteRoom")]
        public IActionResult DeleteBookingRoom(int roomId)
        {
            _bookingRoomService.DeleteRoom(roomId);
            return Ok("Room deleted successfully");
        }
#endregion       
        #region UPDATE ROOM
        [HttpPut("UpdateRoom")]
        public IActionResult PutBookingRoom(BookingRoom room)
        {
            _bookingRoomService.UpdateRoom(room);
            return Ok("Room updated successfully");
        }
#endregion
    }
}
