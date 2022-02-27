using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblLogTerritorySalesForceChange
    {
        public long IntLogId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntTerritoryId { get; set; }
        public long IntEmployeeId { get; set; }
        public DateTime DteFromDate { get; set; }
        public DateTime? DteToDate { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
