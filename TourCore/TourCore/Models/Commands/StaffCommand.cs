﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourCore.Models.Commands
{
    public class StaffCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
    }
}
