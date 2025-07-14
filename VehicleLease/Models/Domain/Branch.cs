using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLease.Models.Domain
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string Region { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}