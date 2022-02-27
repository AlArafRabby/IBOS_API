using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferItemGroupHeader
{
    public class CreateTradeOfferItemGroupRow
    {
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long TradeOfferItemGroupId { get; set; }
        [Required]
        public long ItemId { get; set; }

    }
}
