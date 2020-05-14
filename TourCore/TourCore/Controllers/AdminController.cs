using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourCore.Services;

namespace TourCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly QuantitySevice _quantitySevice;
        private readonly TravelService _travelService;
        public AdminController(QuantitySevice quantitySevice, TravelService travelService)
        {
            this._quantitySevice = quantitySevice;
            this._travelService = travelService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult QuantityMember()
        {
            var model = this._quantitySevice.QuantityMember();
            return View(model);
        }
        public IActionResult Travel()
        {
            var model = this._travelService.ListTravel();
            ViewBag.Info = string.Empty;
            return View(model);
        }
        public IActionResult AddStaff()
        {
            return View();
        }
        public IActionResult InsertTour()
        {

        }
    }
}