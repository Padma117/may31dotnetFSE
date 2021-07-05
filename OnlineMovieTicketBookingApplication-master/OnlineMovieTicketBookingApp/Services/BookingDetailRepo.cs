using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Services
{
    public class BookingDetailRepo : IRepo<BookingDetail, int>
    {
        private CinemaContext _context;
        private ILogger<BookingDetailRepo> _logger;

        public BookingDetailRepo(CinemaContext context, ILogger<BookingDetailRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public int Add(BookingDetail t)
        {

            try
            {
                _context.BookingDetails.Add(t);
                _context.SaveChanges();
                _logger.LogInformation("BookingDetail updated Successfully", t);
                return t.booking_id;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not Book " + DateTime.Now.ToString());
                _logger.LogError("The details " + e.Message);
            }
            return -1;
        }


        public bool Delete(int k)
        {
            try
            {
                _context.Remove(_context.BookingDetails.Single(a => a.Ticket_Id == k));
                _context.SaveChanges();
                _logger.LogInformation("BookingDetails Cancelled Sucessfully", k);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Could not Cancel the tickets " + DateTime.Now.ToString() + " Please try Later");
                _logger.LogError("The details " + e.Message);
            }
            return false;
        }

        public BookingDetail Edit(int k, BookingDetail t)
        {
            throw new NotImplementedException();
        }

        public BookingDetail Get(int k)
        {
            try
            {
                var bookingDetail = _context.BookingDetails.SingleOrDefault(m => m.customer_id == k);
                return bookingDetail;
            }
            catch (ArgumentNullException ane)
            {
                _logger.LogError("The argument is null " + ane.Message);
            }
            catch (Exception e)
            {
                _logger.LogError("The details " + e.Message);
            }
            return null;
        }

        public ICollection<BookingDetail> GetAll()
        {
            if (_context.BookingDetails.Count() == 0)
            {
                return null;
            }
            return _context.BookingDetails.ToList();
        }
    }
}
