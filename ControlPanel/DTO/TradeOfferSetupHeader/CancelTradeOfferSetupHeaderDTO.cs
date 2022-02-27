using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupHeader
{
    public class CancelTradeOfferSetupHeaderDTO
    {
        [Required]
        public long TradeOfferConditionId { get; set; }
        public long ActionBy { get; set; }

    }
}
