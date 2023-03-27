using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IBookingRoomRepository
    {
        void AddRoom(BookingRoom room);
        void UpdateRoom(BookingRoom room);
        void DeleteRoom(int roomId);
        BookingRoom GetRoomById(int roomId);
        IEnumerable<BookingRoom> GetBookingRoom();
    }
}
