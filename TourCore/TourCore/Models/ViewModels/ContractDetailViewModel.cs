using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.ViewModels
{
    public class ContractDetailViewModel
    {
        public int Id { get; set; }
        public int PeopleGo { get; set; }
        public decimal? Cost { get; set; }
        public string NameTour { get; set; }
        public int ContractId { get; set; }
        public string Code { get; set; }
        public string NameCustomer { get; set; }

        public DateTime BeginDate { get; set; }
        public bool Paid { get; set; }

        public int TourId { get; set; }
        public int StaffId { get; set; }
    }
}
