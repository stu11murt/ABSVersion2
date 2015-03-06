using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public interface IBookingRepository
    {
        List<Booking> GetAllBookings();
        Booking GetBookingById(int id);
        void AddBooking(Booking booking);
        void UpdateBooking(int id, Booking booking);
        void DeleteBooking(Booking booking);
        void Save();
    }
}
