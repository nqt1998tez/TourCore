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
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly TourContext _db;
        public TourController(TourService tourService,TourContext db)
        {
            this._db = db;
            this._tourService = tourService;
        }
     
        public IActionResult Index()
        {
            ViewData["ShowInTour"] = _tourService.ShowInTour();
            return View();
        }
        public IActionResult TourDetail(int? id)
        {
            if(id==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            var model = _tourService.TourDetail(id);
            if(model==null)
            {
                return null;
            }
            return View(model);
        }
    }
}