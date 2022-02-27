using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblPriceSetup
    {
        public long IntPriceConditionId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntConditionTypeId { get; set; }
        public string StrConditionTypeName { get; set; }
        public long IntConditionReffId { get; set; }
        public long IntItemId { get; set; }
        public decimal NumPrice { get; set; }
        public DateTime DteStartDate { get; set; }
        public DateTime? DteEndDate { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
