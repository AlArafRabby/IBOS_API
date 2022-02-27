using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferItemGroupHeader
{
    public class CreateTradeOfferItemGroupHeaderCommon
    {
        public List<CreateTradeOfferItemGroupRow> TradeOfferItemGroupRow { get; set; }
        public CreateTradeOfferItemGroupHeader TradeOfferItemGroupHeader { get; set; }
    }
}
