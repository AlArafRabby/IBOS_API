using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessArea
    {
        public long IntBusinessAreaId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public string StrBusinessAreaCode { get; set; }
        public string StrBusinessAreaName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
