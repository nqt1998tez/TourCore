using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;

namespace TourCore.Models.ViewModels
{
    public class TourViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Day { get; set; }
        public int Night { get; set; }
        public decimal Cost { get; set; }
        public string Picture { get; set; }
        public bool TopHot { get; set; }
        public bool NewTour { get; set; }
        public decimal Discount { get; set; }
        public int NumberBooking { get; set; }
        public string Description { get; set; }
        public int InTour { get; set; }
        public int OutTour { get; set; }
    }
}
