using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblProductDivision
    {
        public long IntProductDivisionId { get; set; }
        public long IntClientId { get; set; }
        public string StrProductDivisionCode { get; set; }
        public string StrProductDivisionName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
