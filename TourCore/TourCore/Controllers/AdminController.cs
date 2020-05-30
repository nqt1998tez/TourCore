using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Commands;
using TourCore.Models.Db;
using TourCore.Services;
using X.PagedList;
namespace TourCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly QuantitySevice _quantitySevice;
        private readonly TravelService _travelService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly TourContext _db;
        public AdminController(QuantitySevice quantitySevice, TravelService travelService,
                              IHostingEnvironment hostingEnvironment, TourContext db)
        {

            this._hostingEnvironment = hostingEnvironment;
            this._quantitySevice = quantitySevice;
            this._travelService = travelService;
            this._db = db;
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
        [HttpGet]
        public IActionResult InsertTour()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertTour(InsertTourCommand tourCommand)
        {
            string getNamePicture = null;
            if(tourCommand.Picture!=null)
            {
                getNamePicture = Path.GetFileName(tourCommand.Picture.FileName);
                var uploadFolder = Path.Combine(this._hostingEnvironment.WebRootPath,"images/tour_images");
                var getPictureToFolder = Path.Combine(uploadFolder,getNamePicture);
                if (System.IO.File.Exists(getPictureToFolder))
                {
                    ViewBag.Picture = "Hình ảnh đã tồn tại";
                    return View();
                }
                else
                {
                    var filestream = new FileStream(getPictureToFolder, FileMode.Create);
                    tourCommand.Picture.CopyTo(filestream);
                    var newTour = new Tour();
                    {
                        newTour.NameTour = tourCommand.NameTour;
                        newTour.Code = tourCommand.Code;
                        newTour.Day = tourCommand.Day;
                        newTour.Night = tourCommand.Night;
                        if (tourCommand.CheckNational == 1)
                        {
                            newTour.OutTour = 1;
                        }
                        else
                        {
                            newTour.InTour = tourCommand.CheckNational;
                        }
                        newTour.Description = tourCommand.Description;
                        newTour.Cost = tourCommand.Cost;
                        newTour.Discount = tourCommand.Discount;
                        newTour.Quantity = tourCommand.Quantity;
                        newTour.Picture = getNamePicture;
                    }
                    _db.Tours.Add(newTour);
                    _db.SaveChanges();
                    RedirectToAction("Index");
                }
            }
            return View();
        }
        public IActionResult ShowAllTour(int? page)
        {
            if (page == null) page=1;
            var allTour = this._travelService.ShowAllTour();
            allTour.OrderBy(x=>x.Id);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(allTour.ToPagedList(pageNumber,pageSize));
        }
        [HttpGet]
        public IActionResult EditTour(int id)
        {
            var model = this._travelService.SeeTour(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditTour(InsertTourCommand command)
        {
            this._travelService.EditTour(command);
            return RedirectToAction("ShowAllTour", "Admin");
        }
        public IActionResult DeleteTour(InsertTourCommand command)
        {
            this._travelService.DeleteTour(command);
            return RedirectToAction("ShowAllTour","Admin");
        }
    }
}