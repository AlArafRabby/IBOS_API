using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferItemGroupHeader
{
    public class CancelTradeOfferItemGroupHeaderDTO
    {
        [Required]
        public long TradeOfferItemGroupId { get; set; }
        public long ActionBy { get; set; }
    }
}
