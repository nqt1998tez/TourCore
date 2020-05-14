using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class TravelService
    {
        private readonly TourContext _db;
        public TravelService(TourContext db)
        {
            this._db = db;
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

    }
}
