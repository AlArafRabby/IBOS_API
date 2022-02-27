using ControlPanel.DTO.TradeOfferSetupRow;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class TradeOfferSetupRow : ITradeOfferSetupRow
    {
        public Task<object> CreateTradeOfferSetupRow(CreateTradeOfferSetupRowDTO postTradeOfferSetupRow)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetTradeOfferSetupRowById(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
