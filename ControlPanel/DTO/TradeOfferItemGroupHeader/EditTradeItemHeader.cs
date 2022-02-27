using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferItemGroupHeader
{
    public class EditTradeItemHeader
    {
        [Required]
        public long TradeOfferGroupId { get; set; }
        [Required]
        public string TradeOfferItemGroupName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }

    }
}
