using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.ViewModels;

namespace TourCore.Models.Db
{
    [Table("Tour")]
    public class Tour
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameTour { get; set; }
        public int? Day { get; set; }
        public int? Night { get; set; }
        public decimal? Cost { get; set; }
        public string Picture { get; set; }
        public bool? TopHot { get; set; }
        public bool? NewTour { get; set; }
        public decimal? Discount { get; set; }
        public int? InTour { get; set; }
        public int? OutTour { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public Tour(TourViewModel tourViewModel)
        {
            this.Id = tourViewModel.Id;
            this.Cost = tourViewModel.Cost;
            this.Code = tourViewModel.Code;
            this.NameTour = tourViewModel.NameTour;
            this.Day = tourViewModel.Day;
            this.Night = tourViewModel.Night;
            this.Picture = tourViewModel.Picture;
            this.TopHot = tourViewModel.TopHot;
            this.NewTour = tourViewModel.NewTour;
            this.Discount = tourViewModel.Discount;
        }
        public Tour()
        {

        }
    }
}
