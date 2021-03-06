using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOffice
    {
        public long IntSalesOfficeId { get; set; }
        public string StrSalesOfficeName { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
