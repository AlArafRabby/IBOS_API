using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
  public  interface ITradeOfferItemGroupRow
    {
        Task<Message> GetTradeOfferItemGroupRowById(long Id);      
        Task<object> CreateTradeOfferItemGroupRow();
        Task<object> EditTradeOfferItemGroupRow();
    }
}
