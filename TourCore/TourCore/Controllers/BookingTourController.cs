using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;
using TourCore.Services;

namespace TourCore.Controllers
{
    public class BookingTourController : Controller
    {
        private readonly TourContext _db;
        private readonly BookingService _bookingService;
        public BookingTourController(TourContext db,BookingService bookingService)
        {
            this._db = db;
            this._bookingService = bookingService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BookingTour(CustomerViewModel customer)
        {
            if(ModelState.IsValid)
            {
                this._bookingService.BookingTour(customer);
            }
            return View();
        }
    }
}