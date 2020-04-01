using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using TourCore.Models.Db;
using Microsoft.EntityFrameworkCore;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class MenuService
    {
        private readonly TourContext _db;
        public MenuService(TourContext db)
        {
            this._db = db;
        }  
        public  List<MenuViewModel> GetMenu()
        {
            //var menu=_db.Menus.ToList();
            //foreach (var item in menu)
            //{
            //    MenuViewModel menus = new MenuViewModel();
            //    menus.Name = item.Name;
            //}
            var menus = new List<MenuViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                menus = conn.Query<MenuViewModel>(@"select Name from Menu").ToList();
                conn.Close();
            }
            return menus;
        }
    }
}
