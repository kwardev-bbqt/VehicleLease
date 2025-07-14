using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLease.Models.ViewModels
{
    public class ReportViewModel
    {
        public string SupplierName { get; set; }
        public string BranchLocation { get; set; }
        public string ClientName { get; set; }
        public int VehicleCount { get; set; }
    }

}