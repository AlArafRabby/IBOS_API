using ControlPanel.DTO.TradeOfferSetupRow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupHeader
{
    public class CreateTradeOfferSetupCommonDTO
    {
        public List<CreateTradeOfferSetupRowDTO> TradeOfferSetupRow { get; set; }
        public CreateTradeOfferSetupHeaderDTO TradeOfferSetupHeader { get; set; }
    }
}
