﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class QuantitySevice
    {
        private readonly TourContext _db;
        public QuantitySevice(TourContext db)
        {
            this._db = db;
        }
        public List<MemberViewModel>QuantityMember()
        {
            var quantities = _db.Members.ToList();
            var members = new List<MemberViewModel>();
            foreach (var item in quantities)
            {
                MemberViewModel member = new MemberViewModel();
                member.Id = item.Id;
                member.Username = item.Username;
                member.Password = item.Password;
                member.Email = item.Email;
                members.Add(member);
            }
            return members;
        }
        public int NumberMember()
        {
            var numbers = _db.Members.Count();
            return numbers;
        }
        public int NumberBooking()
        {
            var numbers = _db.ContractDetails.Count();
            return numbers;
        }
    }
}
