using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IBookingSeatRepository
    {
        void AddSeat(BookingSeat seat);
        void DeleteSeat(int seatId);
        void UpdateSeat(BookingSeat seat);
        BookingSeat GetBookingSeatId(int seatId);
        IEnumerable<BookingSeat> GetAllSeats();
    }
}
