using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLease.Models.Domain
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}