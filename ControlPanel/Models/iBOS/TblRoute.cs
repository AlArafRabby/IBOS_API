using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblRoute
    {
        public long IntRouteId { get; set; }
        public string StrRouteName { get; set; }
        public string StrRouteAddress { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
