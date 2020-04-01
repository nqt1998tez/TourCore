using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.Db
{
    [Table("Contract")]
    public class Contract
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public bool Paid { get; set; }
        public string Content { get; set; }
        [ForeignKey("Member")]
        public int MembershipId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }


    }
}
