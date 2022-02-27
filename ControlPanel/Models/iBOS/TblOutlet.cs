using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblOutlet
    {
        public long IntOutletId { get; set; }
        public long IntClientId { get; set; }
        public string StrOutletCode { get; set; }
        public string StrOutletName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
