using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;

namespace ABSDAL
{
    public class BookingRepository : IBookingRepository, IDisposable
    {
        ABSEntities bookEntities = new ABSEntities();

        #region IBookRepository Members


        public BookingRepository()
        {
            bookEntities = new ABSEntities();
        }

        public List<Booking> GetAllBookings()
        {
            return bookEntities.Bookings.ToList();
        }

        public Booking GetBookingById(int id)
        {
            return bookEntities.Bookings.SingleOrDefault(book => book.BookingID == id);
        }

        public void AddBooking(Booking booking)
        {
            bookEntities.Bookings.Add(booking);
        }

        public void UpdateBooking(int id, Booking booking)
        {
            Booking b = GetBookingById(id);
            b = booking;
        }

        public void DeleteBooking(Booking booking)
        {
            bookEntities.Bookings.Remove(booking);
        }

        public void Save()
        {
            bookEntities.SaveChanges();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing == true)
            {
                bookEntities = null;
            }
        }

        ~BookingRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}
