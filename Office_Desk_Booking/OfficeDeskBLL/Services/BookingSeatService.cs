using OfficeDeskDAL.Repository;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskBLL.Services
{
    public class BookingSeatService
    {
        IBookingSeatRepository _seatRepository;

        public BookingSeatService(IBookingSeatRepository seatRepository)
        {
            _seatRepository = seatRepository;
        }

        public void AddSeat(BookingSeat seat)
        {
            _seatRepository.AddSeat(seat);
        }

        public void DeleteSeat(int seatId)
        {
            _seatRepository.DeleteSeat(seatId);
        }

        public void UpdateSeat(BookingSeat seat)
        {
            _seatRepository.UpdateSeat(seat);
        }

        public BookingSeat GetSeatById(int seatId)
        {
            return _seatRepository.GetBookingSeatId(seatId);
        }

        public IEnumerable<BookingSeat> GetAllSeat()
        {
            return _seatRepository.GetAllSeats();
        }
    }
}
