using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.ViewModels;

namespace TourCore.Models.Db
{
    [Table("Customer")]
    public class Customer
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? MembershipId { get; set; }

        public Customer(CustomerViewModel customer)
        {
            this.Id = customer.Id;
            this.Name = customer.Name;
            this.Address = customer.Address;
            this.Email = customer.Email;
            this.DOB = customer.DOB;
            this.Phone = customer.Phone;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
        }
        public Customer()
        { }
    }
}
