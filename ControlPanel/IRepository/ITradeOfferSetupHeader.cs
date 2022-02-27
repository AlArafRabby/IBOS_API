using ControlPanel.DTO.TradeOfferSetupHeader;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface ITradeOfferSetupHeader
    {  
        Task<Message> GetTradeOfferSetupHeaderById(long Id);
        Task<Message> GetTradeOfferSetupHeaderByUnitId(long UId);
        Task<Message> GetTradeOfferSetupHeaderByClientId(long CId);
        Task<Message> GetTradeOfferbyItemId(long itemid);
        Task<Message> GetTradeOfferSetupHeaderByPartnerId(long PId);
        Task<object> CreateTradeOfferSetupHeader(CreateTradeOfferSetupCommonDTO postTradeOfferSetupHeadercommon);
        Task<object> CancelTradeOfferSetupHeader(CancelTradeOfferSetupHeaderDTO TradeOfferSetupHeader);
    }
}
