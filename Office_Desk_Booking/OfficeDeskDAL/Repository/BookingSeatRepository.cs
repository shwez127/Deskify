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
    public class BookingSeatRepository : IBookingSeatRepository
    {
        DeskDbContext _db;
        public BookingSeatRepository(DeskDbContext db) 
        {
            _db = db;
        }
        #region AddBookingSeat
        public void AddSeat(BookingSeat seat)
        {
            _db.bookingSeats.Add(seat);
            _db.SaveChanges();
        }
        #endregion AddBookingSeat

        #region DeleteBookingSeat
        public void DeleteSeat(int seatId)
        {
            var seat = _db.bookingSeats.Find(seatId);
            _db.bookingSeats.Remove(seat);
            _db.SaveChanges();

        }
        #endregion DeleteBookingSeat

        #region  UpdateSeat
        public void UpdateSeat(BookingSeat seat)
        {
            _db.Entry(seat).State = EntityState.Modified;
            _db.SaveChanges();

        }
        #endregion UpdateSeat


        #region GetSeatById 
        public BookingSeat GetBookingSeatId(int seatId)
        {
            return _db.bookingSeats.Find(seatId);
        }
        #endregion GetSeatById

        #region GetAllSeats
        public IEnumerable<BookingSeat> GetAllSeats()
        {
            return _db.bookingSeats;
        }
        #endregion GetAllSeats
    }
}
