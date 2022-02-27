using ControlPanel.DTO.TradeOfferSetupRow;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface ITradeOfferSetupRow
    {
        Task<Message> GetTradeOfferSetupRowById(long Id);
        Task<object> CreateTradeOfferSetupRow(CreateTradeOfferSetupRowDTO postTradeOfferSetupRow);
    }
}
