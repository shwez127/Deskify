﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeDeskBLL.Services;
using OfficeDeskEntity.Models;

namespace OfficeDeskBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorController : ControllerBase
    {
        private FloorService _floorService;
        public FloorController(FloorService floorService)
        {
            _floorService = floorService;
        }

        #region GET FLOOR

        [HttpGet("GetFloor")]
        public IEnumerable<Floor> GetFloors()
        {
            return _floorService.GetFloor();
        }

        #endregion

        #region GET FLOORBYID

        [HttpGet("GetFloorById")]
        public Floor GetFloorById(int floorId)
        {
            return _floorService.GetFloorById(floorId);
        }

        #endregion

        #region ADD FLOOR

        [HttpPost("AddFloor")]
        public IActionResult AddFloor([FromBody] Floor floor)
        {
            _floorService.AddFloor(floor);
            return Ok("Floor Created successfully");
        }

        #endregion

        #region DELETE FLOOR

        [HttpDelete("DeleteFloor")]
        public IActionResult DeleteFloor(int floorId)
        {
            _floorService.DeleteFloor(floorId);
            return Ok("Message Deleted sucessfully!!!");
        }

        #endregion

        #region UPDATE FLOOR

        [HttpPut("UpdateFloor")]
        public IActionResult UpdateFloor([FromBody] Floor floor)
        {
            _floorService.UpdateFloor(floor);
            return Ok("Floor Updated successfully");
        }

        #endregion
    }
}
