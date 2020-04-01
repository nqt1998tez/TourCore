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
            var showInTour = new List<TourViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                showInTour = conn.Query<TourViewModel>(@"select * from Tour where InTour=1").ToList();
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
