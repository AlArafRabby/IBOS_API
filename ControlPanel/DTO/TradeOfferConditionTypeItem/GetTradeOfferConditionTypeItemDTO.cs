using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferConditionTypeItem
{
    public class GetTradeOfferConditionTypeItemDTO
    {
        [Required]
        public long TradeOfferConditionTypeId { get; set; }
        public string TradeOfferConditionTypeName { get; set; }
        public long AccessSequence { get; set; }
    }
}
