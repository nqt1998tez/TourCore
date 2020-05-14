    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.Commands
{
    public class BookingTourCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int PeopleGo { get; set; }

        public DateTime DOB { get; set; }
        public int TourId { get; set; }
    }
}
