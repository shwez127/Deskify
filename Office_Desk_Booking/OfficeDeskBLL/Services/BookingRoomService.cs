using OfficeDeskDAL.Repository;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskBLL.Services
{
    public class BookingRoomService
    {
        IBookingRoomRepository _roomRepository;
        public BookingRoomService(IBookingRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        //CRUD service operations for BookingRoom
        public void AddRoom(BookingRoom room)
        {
            _roomRepository.AddRoom(room);
        }
        public void UpdateRoom(BookingRoom room)
        {
            _roomRepository.UpdateRoom(room);
        }
        public void DeleteRoom(int roomId)
        {
            _roomRepository.DeleteRoom(roomId);
        }
        //get room by id
        public BookingRoom GetRoomById(int roomId)
        {
            return _roomRepository.GetRoomById(roomId);
        }
        //get rooms
        public IEnumerable<BookingRoom> GetBookingRoom()
        {
            return _roomRepository.GetBookingRoom();
        }

    }
}
