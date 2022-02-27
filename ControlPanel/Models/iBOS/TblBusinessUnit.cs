using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessUnit
    {
        public long IntBusinessUnitId { get; set; }
        public long IntClientId { get; set; }
        public string StrBusinessUnitCode { get; set; }
        public string StrBusinessUnitName { get; set; }
        public string StrBusinessUnitAddress { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
