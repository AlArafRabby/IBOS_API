using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblTradeOfferSetupRow
    {
        public long IntRowId { get; set; }
        public long IntTradeOfferConditionId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public bool IsValueBase { get; set; }
        public bool IsSlabProgram { get; set; }
        public decimal NumBaseFrom { get; set; }
        public decimal NumBaseTo { get; set; }
        public decimal NumOfferPercent { get; set; }
        public decimal NumOfferAmount { get; set; }
        public long IntOfferItemId { get; set; }
        public long IntOfferItemUom { get; set; }
        public decimal NumOfferQuantity { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
