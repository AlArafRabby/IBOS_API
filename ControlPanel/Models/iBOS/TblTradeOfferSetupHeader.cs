using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblTradeOfferSetupHeader
    {
        public long IntTradeOfferConditionId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntPriceConditionTypeId { get; set; }
        public string StrPriceConditionTypeName { get; set; }
        public long IntPriceConditionReffId { get; set; }
        public long IntTradeOfferConditionTypeId { get; set; }
        public string StrTradeOfferConditionTypeName { get; set; }
        public long IntTradeOfferConditionReffId { get; set; }
        public long IntRoundingTypeId { get; set; }
        public bool IsMinimumApplied { get; set; }
        public bool IsValueBase { get; set; }
        public bool IsSlabProgram { get; set; }
        public DateTime DteStartDate { get; set; }
        public DateTime? DteEndDate { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
