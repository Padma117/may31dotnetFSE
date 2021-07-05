using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBookingApp.Models;
using OnlineMovieTicketBookingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace OnlineMovieTicketBookingApp.Controllers
{
    public class BookingDetailController : Controller
    {
       
        private readonly CinemaContext _context;
        private readonly IRepo<BookingDetail, int> _repo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<BookingDetailController> _logger;

        public BookingDetailController(CinemaContext context, IRepo<BookingDetail, int> repo, IWebHostEnvironment webHostEnvironment, ILogger<BookingDetailController> logger)
        {
            _repo = repo;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var bookingDetails = _repo.GetAll();
            if (bookingDetails == null)
            {
                ViewBag.Message = "Booking not done yet";
                return View();
            }
            return View(bookingDetails);
        }

        public IActionResult Create()
        {
            BookingDetail bookingDetail = new BookingDetail();
            return View(bookingDetail);

        }

        [HttpPost]
        //public async Task<IActionResult> Create(BookingDetail bookingDetail)
        public async Task<IActionResult> CreateAsync(BookingDetail bookingDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BookingDetail myBookingDetail = bookingDetail;
                    //if (movie.Poster_File != null)
                    //{
                    //    try
                    //    {
                    //        string folder = "/MoviePosters";
                    //        folder += Guid.NewGuid().ToString() + myMovie.Poster_File.FileName;
                    //        string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                    //        await myMovie.Poster_File.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                    //        ViewBag.Message = "File uploaded successfully";

                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    //    }
                    //}
                    //else
                    //{
                    //    ViewBag.Message = "You have not specified a file.";
                    //}


                    bookingDetail.booking_id = _repo.Add(myBookingDetail);
                    return RedirectToAction("List");

                }
                else
                {
                    return View();
                }


            }
            catch (Exception)
            {
                _logger.LogDebug("Add Booking failed " + bookingDetail);
            }
            ViewBag.Message = "Add Booking Failed";
            return View();

        }

        public IActionResult List()
        {
            var bookingDetails = _repo.GetAll();
            if (bookingDetails == null)
            {
                ViewBag.Message = "No Bookings available";
                return View();
            }
            return View(bookingDetails);
        }

        public IActionResult Details(int id)
        {
            
           var bookingDetails = _repo.Get(id);
            if (bookingDetails == null)
            {
                ViewBag.Message = "No Bookings available";
                return View();
            }
            return View(bookingDetails);

            
        }

        public IActionResult Delete(int id)
        {
            BookingDetail bookingDetail;
            try
            {
                bookingDetail = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                bookingDetail = null;
            }
            catch (InvalidOperationException)
            {
                bookingDetail = null;
            }

            return View(bookingDetail);

        }

        [HttpPost]
        public IActionResult Delete(int id, BookingDetail bookingDetail)
        {
            try
            {
                if (_repo.Delete(id))
                {
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Message("Cancel BookingDetail unsuccessful.");
                    return View();
                }

            }
            catch (Exception)
            {
                _logger.LogDebug("Cancel bookingDetail failed " + bookingDetail);
            }
            return View();

        }

        public IActionResult Edit(int id)
        {

            BookingDetail bookingDetail;
            try
            {
                bookingDetail = _repo.Get(id);

            }
            catch (ArgumentNullException)
            {
                bookingDetail = null;
            }
            catch (InvalidOperationException)
            {
                bookingDetail = null;
            }

            return View(bookingDetail);
        }

        [HttpPost]
        public IActionResult Edit(int id, BookingDetail bookingDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BookingDetail bookingDetail1 = _repo.Edit(id, bookingDetail);
                    return RedirectToAction("List");

                }
            }
            catch (Exception)
            {
                _logger.LogDebug("Edit Booking failed " + bookingDetail);
            }
            return View();
        }

    }


}
