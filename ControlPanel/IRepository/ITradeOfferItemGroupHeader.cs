using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.TradeOfferItemGroupHeader;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
  public  interface ITradeOfferItemGroupHeader
    {
        Task<Message> GetTradeOfferItemGroupHeaderById(long Id);
        Task<Message> GetTradeOfferItemGroupHeaderByUnitId(long UId);
        Task<Message> GetTradeOfferItemGroupHeaderByClientId(long CId);
        Task<object> CreateTradeOfferItemGroupHeader(CreateTradeOfferItemGroupHeaderCommon TradeOfferItemGroupHeader);
        Task<object> EditTradeOfferItemGroupHeader(EditTradeOfferItemGroupHeaderCommon TradeOfferItemGroupHeaderCommon);
        Task<object> CancelTradeOfferItemGroupHeader(CancelTradeOfferItemGroupHeaderDTO TradeOfferItemGroupHeader);
    }
}
