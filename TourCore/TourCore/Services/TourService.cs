using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class TourService
    {
        private readonly TourContext _db;
        public TourService(TourContext db)
        {
            this._db = db;
        }
        public List<TourViewModel> ShowInTour()
        {
            //var tours = _db.Tours.Where(n=>n.InTour==1).ToList();
            var showInTour = new List<TourViewModel>();
            //foreach (var item in tours)
            //{
            //    TourViewModel tourView = new TourViewModel();
            //    tourView.NameTour = item.NameTour;
            //    tourView.Day = item.Day;
            //    tourView.Night = item.Night;
            //    tourView.Cost = item.Cost;
            //    tourView.Code = item.Code;
            //    tourView.Description = item.Description;
            //    showInTour.Add(tourView);
            //}

            // --Use Dapper--
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                showInTour = conn.Query<TourViewModel>(@"select * from Tour where InTour=0").ToList();
                conn.Close();
            }
            return showInTour;
        }
        //public List<TourViewModel> TourDetail(int? id)
        //{
        //    var showInTour = new List<TourViewModel>();
        //    using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
        //    {
        //        conn.Open();
        //        List<TourViewModel> tourId = conn.Query<TourViewModel>(@"select * from Tour where Id="+id).ToList();
        //        foreach (var item in tourId)
        //        {
        //            showInTour.Add(item);
        //        }   
        //        conn.Close();
        //    }
        //    return showInTour;
        //}
        public TourViewModel TourDetail(int? id)
        {
            var tourId = new List<TourViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourId = conn.Query<TourViewModel>("select * from Tour where Id=" + id).ToList();
                conn.Close();
            }
            return tourId.SingleOrDefault(n => n.Id == id);
        }
    }

}
