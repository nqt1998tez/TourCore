using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TourCore.Models.Db;

namespace TourCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly TourContext _db;
        public HomeController(TourContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
      

       
    }
}
