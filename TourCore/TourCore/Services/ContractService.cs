using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class ContractService
    {
        private readonly TourContext _db;
        private readonly CustomerViewModel _customerViewModel;
        public ContractService(TourContext db,CustomerViewModel customerViewModel)
        {
            this._db = db;
        }
        public void InsertContract(CustomerViewModel customer)
        {
            ContractViewModel contract = new ContractViewModel();
            {
                contract.CustomerId = customer.Id;
                contract.BeginDate = DateTime.Now;
                contract.Paid = false;
                contract.Content = "abc";
            }
            _db.Contracts.Add(new Contract(contract));
            _db.SaveChanges();
        }
    }
}
