using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblVehicle
    {
        public long IntVehicleId { get; set; }
        public string StrVehicleNo { get; set; }
        public string StrVehicleCode { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntClientId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
