using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ABSDAL;
using ABSCore1.Models;

namespace ABSCore1.Controllers
{
    public class BookingController : Controller
    {
        private IBookingRepository bookingRepository = new BookingRepository();

        
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewBooking()
        {
            NewBookingModel newBooking = new NewBookingModel();
            newBooking.eventDate = DateTime.Now;
            newBooking.startTime = DateTime.Now;
            newBooking.endTime = DateTime.Now;
            //Booking booking = bookingRepository.GetBookingById(1);
            return View(newBooking);
        }

        [HttpPost]
        public ActionResult NewBooking(NewBookingModel newBooking)
        {
            Booking newbook = new Booking();
            newbook.GroupOrganiser = newBooking.groupOrganiser;
            bookingRepository.AddBooking(newbook);
            //and this is for github
            return View();

        }
    }
}