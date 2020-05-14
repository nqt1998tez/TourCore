using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.Db
{
    [Table("ContractDetail")]
    public class ContractDetail
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int PeopleGo { get; set; }
        public decimal? Cost { get; set; }
        public string NameTour { get; set; }
        public int TourId { get; set; }
        public int? StaffId { get; set; }

    }
}
