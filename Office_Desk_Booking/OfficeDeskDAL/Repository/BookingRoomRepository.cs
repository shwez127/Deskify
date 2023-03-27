using Microsoft.EntityFrameworkCore;
using OfficeDeskDAL.Data;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public class BookingRoomRepository:IBookingRoomRepository
    {
        DeskDbContext _db;
        public BookingRoomRepository(DeskDbContext db)
        {
            _db = db;
        }
        #region ADD ROOM
        public void AddRoom(BookingRoom room)
        {
            _db.bookingRooms.Add(room);
            _db.SaveChanges();
        }
        #endregion         

        #region GET ROOM
        public IEnumerable<BookingRoom> GetBookingRoom()
        {
            return _db.bookingRooms.ToList();
        }
        #endregion  

        #region BOOKINGBYID
        public BookingRoom GetRoomById(int roomId)
        {
            return _db.bookingRooms.Find(roomId);
        }
#endregion     

        #region UPDATE ROOM
        public void UpdateRoom(BookingRoom room)
        {
            _db.Entry(room).State = EntityState.Modified;
            _db.SaveChanges(); ;
        }
#endregion       

        #region DELETE ROOM
        public void DeleteRoom(int roomId)
        {
            var rooms = _db.bookingRooms.Find(roomId);
            _db.bookingRooms.Remove(rooms);
            _db.SaveChanges();
        }
#endregion       

        #region DELETE ROOM
        public void DeleteRoom(BookingRoom room)
        {
            throw new NotImplementedException();
        }
#endregion
    }
}
