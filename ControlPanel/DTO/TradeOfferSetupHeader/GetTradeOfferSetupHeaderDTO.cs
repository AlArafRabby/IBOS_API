using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupHeader
{
    public class GetTradeOfferSetupHeaderDTO
    {
        [Required]
        public long TradeOfferConditionId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long PriceConditionTypeId { get; set; }
        public string PriceConditionTypeName { get; set; }
        public long PriceConditionReffId { get; set; }
        public long TradeOfferConditionTypeId { get; set; }
        public string TradeOfferConditionTypeName { get; set; }
        public long TradeOfferConditionReffId { get; set; }
        public long RoundingTypeId { get; set; }
        public string RoundingTypeName { get; set; }
        public bool MinimumApplied { get; set; }
        public bool ValueBase { get; set; }
        public bool SlabProgram { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
