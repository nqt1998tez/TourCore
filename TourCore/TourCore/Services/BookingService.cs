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
    public class BookingService
    {
        private readonly TourContext _db;
        public BookingService(TourContext db)
        {
            this._db = db;
        }
        public void BookingTour(CustomerViewModel customer)
        {
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                _db.Customers.Add(new Customer(customer));
                _db.SaveChanges();
                conn.Close();
            }
        }
    }
}
