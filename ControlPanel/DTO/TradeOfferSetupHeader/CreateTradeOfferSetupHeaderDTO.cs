using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupHeader
{
    public class CreateTradeOfferSetupHeaderDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long PriceConditionTypeId { get; set; }
        [Required]
        public string PriceConditionTypeName { get; set; }
        [Required]
        public long PriceConditionReffId { get; set; }
        [Required]
        public long TradeOfferConditionTypeId { get; set; }
        [Required]
        public string TradeOfferConditionTypeName { get; set; }
        [Required]
        public long TradeOfferConditionReffId { get; set; }
        [Required]
        public long RoundingTypeId { get; set; }
        [Required]
        public bool MinimumApplied { get; set; }
        [Required]
        public bool ValueBase { get; set; }
        [Required]
        public bool SlabProgram { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
