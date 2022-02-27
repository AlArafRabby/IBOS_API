using ControlPanel.DbContexts;
using ControlPanel.DTO.TradeOfferConditionTypeItem;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class TradeOfferConditionTypeItem : ITradeOfferConditionTypeItem
    {
        public readonly iBOSContext _context;
        public TradeOfferConditionTypeItem(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTradeOfferConditionTypeItemAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All TradeOfferConditionTypeItem Iteme List ",
                    data = await Task.FromResult((from c in _context.TblTradeOfferConditionTypeItem
                                                  select new GetTradeOfferConditionTypeItemDTO()
                                                  {
                                                      TradeOfferConditionTypeId = c.TradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = c.StrTradeOfferConditionTypeName,
                                                      AccessSequence = c.IntAccessSequence

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetTradeOfferConditionTypeItemById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All TradeOfferConditionTypeItem Iteme List ",
                    data = await Task.FromResult((from c in _context.TblTradeOfferConditionTypeItem
                                                  where c.TradeOfferConditionTypeId == Id
                                                  select new GetTradeOfferConditionTypeItemDTO()
                                                  {
                                                      TradeOfferConditionTypeId = c.TradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = c.StrTradeOfferConditionTypeName,
                                                      AccessSequence = c.IntAccessSequence

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
    }
}
