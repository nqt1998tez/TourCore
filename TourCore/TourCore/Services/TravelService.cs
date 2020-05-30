using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Commands;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class TravelService
    {
        private readonly TourContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        public TravelService(TourContext db,IHostingEnvironment hostingEnvironment)
        {
            this._db = db;
            this._hostingEnvironment = hostingEnvironment;
        }
        public List<ContractDetailViewModel> ListTravel()
        {
            var listTravelDb = from c in _db.ContractDetails
                               join t in _db.Tours on c.TourId equals t.Id
                               join ct in _db.Contracts on c.ContractId equals ct.Id
                               join cs in _db.Customers on ct.CustomerId equals cs.Id
                               select new { t.Code, c.NameTour, cs.Name, ct.BeginDate, ct.Paid };
            var listTravel = new List<ContractDetailViewModel>();
            foreach (var item in listTravelDb)
            {
                ContractDetailViewModel viewModel = new ContractDetailViewModel();
                viewModel.Code = item.Code;
                viewModel.NameTour = item.NameTour;
                viewModel.NameCustomer = item.Name;
                viewModel.BeginDate = item.BeginDate;
                viewModel.Paid = item.Paid;
                listTravel.Add(viewModel);
            }
            return listTravel;
        }
        public IQueryable<TourViewModel> ShowAllTour()
        {
            var tours = from t in _db.Tours
                        select new { t.Code, t.Cost, t.Day, t.Night, t.Picture, t.Quantity,t.NameTour,t.Id };

            var tourView = new List<TourViewModel>();
            foreach (var item in tours)
            {
                TourViewModel tourViewModel = new TourViewModel();
                tourViewModel.Id = item.Id;
                tourViewModel.Code = item.Code;
                tourViewModel.Cost = item.Cost;
                tourViewModel.NameTour = item.NameTour;
                tourViewModel.Picture = item.Picture;
                tourViewModel.Quantity = item.Quantity;
                tourViewModel.Day = item.Day;
                tourViewModel.Night = item.Night;
                tourView.Add(tourViewModel);
            }
            return tourView.AsQueryable(); 
        }
        public TourViewModel SeeTour(int id)
        {
            TourViewModel viewModel = new TourViewModel();
            var listTour = _db.Tours.FirstOrDefault(n=>n.Id==id);
            {
                viewModel.Id = listTour.Id;
                viewModel.NameTour = listTour.NameTour;
            }
            return viewModel;
        }
        public void EditTour(InsertTourCommand command)
        {
            var checkTour = _db.Tours.FirstOrDefault(n=>n.Id==command.Id);
            {
                checkTour.Code = command.Code;
                checkTour.Cost = command.Cost;
                checkTour.Day = command.Day;
                checkTour.Night = command.Night;
                checkTour.Quantity = command.Quantity;
                checkTour.Description = command.Description;
                checkTour.Discount = command.Discount;
            }
            _db.SaveChanges();
        }
        public void DeleteTour(InsertTourCommand command)
        {
            var checkTour = _db.Tours.FirstOrDefault(n => n.Id == command.Id);
            _db.Remove(checkTour);
            _db.SaveChanges();
        }
    }
}
