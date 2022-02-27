using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ITradeOfferConditionTypeItem
    {
        Task<Message> GetTradeOfferConditionTypeItemAll();
        Task<Message> GetTradeOfferConditionTypeItemById(long Id);

    }
}
