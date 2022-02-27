using ControlPanel.DbContexts;
using ControlPanel.DTO.TradeOfferSetupHeader;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class TradeOfferSetupHeader : ITradeOfferSetupHeader
    {
        public readonly iBOSContext _context;
        public TradeOfferSetupHeader(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTradeOfferSetupHeaderById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header List By Id.",
                    data = await Task.FromResult((from trs in _context.TblTradeOfferSetupHeader
                                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                                  where trs.IsActive == true && trs.IntTradeOfferConditionId == Id
                                                  select new GetTradeOfferSetupHeaderDTO()
                                                  {
                                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = trs.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName, 
                                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId, 
                                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName, 
                                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId, 
                                                      RoundingTypeId = trs.IntRoundingTypeId,
                                                      RoundingTypeName = rt.StrRoundingTypeName,
                                                      MinimumApplied = trs.IsMinimumApplied,
                                                      ValueBase = trs.IsValueBase, 
                                                      SlabProgram = trs.IsSlabProgram, 
                                                      StartDate = trs.DteStartDate,
                                                      EndDate = trs.DteEndDate,
                                                      ActionBy = trs.IntActionBy,
                                                      LastActionDateTime = trs.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferbyItemId(long itemid)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header List By ItemId.",
                    data = await Task.FromResult((from trs in _context.TblTradeOfferSetupHeader
                                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                                  where trs.IsActive == true && trs.IntTradeOfferConditionTypeId == itemid
                                                  select new GetTradeOfferSetupHeaderDTO()
                                                  {
                                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = trs.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                                      RoundingTypeId = trs.IntRoundingTypeId,
                                                      RoundingTypeName = rt.StrRoundingTypeName,
                                                      MinimumApplied = trs.IsMinimumApplied,
                                                      ValueBase = trs.IsValueBase,
                                                      SlabProgram = trs.IsSlabProgram,
                                                      StartDate = trs.DteStartDate,
                                                      EndDate = trs.DteEndDate,
                                                      ActionBy = trs.IntActionBy,
                                                      LastActionDateTime = trs.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferSetupHeaderByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header List By Id.",
                    data = await Task.FromResult((from trs in _context.TblTradeOfferSetupHeader
                                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                                  where trs.IsActive == true && trs.IntBusinessUnitId == UId
                                                  select new GetTradeOfferSetupHeaderDTO()
                                                  {
                                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = trs.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                                      RoundingTypeId = trs.IntRoundingTypeId,
                                                      RoundingTypeName = rt.StrRoundingTypeName,
                                                      MinimumApplied = trs.IsMinimumApplied,
                                                      ValueBase = trs.IsValueBase,
                                                      SlabProgram = trs.IsSlabProgram,
                                                      StartDate = trs.DteStartDate,
                                                      EndDate = trs.DteEndDate,
                                                      ActionBy = trs.IntActionBy,
                                                      LastActionDateTime = trs.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferSetupHeaderByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header List By Client Id.",
                    data = await Task.FromResult((from trs in _context.TblTradeOfferSetupHeader
                                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                                  where trs.IsActive == true && trs.IntClientId == CId
                                                  select new GetTradeOfferSetupHeaderDTO()
                                                  {
                                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = trs.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                                      RoundingTypeId = trs.IntRoundingTypeId,
                                                      RoundingTypeName = rt.StrRoundingTypeName,
                                                      MinimumApplied = trs.IsMinimumApplied,
                                                      ValueBase = trs.IsValueBase,
                                                      SlabProgram = trs.IsSlabProgram,
                                                      StartDate = trs.DteStartDate,
                                                      EndDate = trs.DteEndDate,
                                                      ActionBy = trs.IntActionBy,
                                                      LastActionDateTime = trs.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferSetupHeaderByPartnerId(long PId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header List By Partner Id.",
                    data = await Task.FromResult((from trs in _context.TblTradeOfferSetupHeader
                                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                                  where trs.IsActive == true && trs.IntBusinessUnitId == PId && trs.IntPriceConditionTypeId == 4
                                                  select new GetTradeOfferSetupHeaderDTO()
                                                  {
                                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = trs.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                                      RoundingTypeId = trs.IntRoundingTypeId,
                                                      RoundingTypeName = rt.StrRoundingTypeName,
                                                      MinimumApplied = trs.IsMinimumApplied,
                                                      ValueBase = trs.IsValueBase,
                                                      SlabProgram = trs.IsSlabProgram,
                                                      StartDate = trs.DteStartDate,
                                                      EndDate = trs.DteEndDate,
                                                      ActionBy = trs.IntActionBy,
                                                      LastActionDateTime = trs.DteLastActionDateTime

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
        public async Task<object> CreateTradeOfferSetupHeader(CreateTradeOfferSetupCommonDTO postTradeOfferSetupHeadercommon)
        {
            try
            {
                var detalis = new TblTradeOfferSetupHeader
                {
                    IntClientId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.ClientId,
                    IntBusinessUnitId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.BusinessUnitId,
                    IntPriceConditionTypeId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.PriceConditionTypeId,
                    StrPriceConditionTypeName = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.PriceConditionTypeName,
                    IntPriceConditionReffId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.PriceConditionReffId,
                    IntTradeOfferConditionTypeId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.TradeOfferConditionTypeId,
                    StrTradeOfferConditionTypeName = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.TradeOfferConditionTypeName,
                    IntTradeOfferConditionReffId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.TradeOfferConditionReffId,
                    IntRoundingTypeId = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.RoundingTypeId,
                    IsMinimumApplied = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.MinimumApplied,
                    IsValueBase = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.ValueBase,
                    IsSlabProgram = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.SlabProgram,
                    DteStartDate = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.StartDate,
                    DteEndDate = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.EndDate,
                    IntActionBy = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.ActionBy,
                    DteLastActionDateTime = postTradeOfferSetupHeadercommon.TradeOfferSetupHeader.LastActionDateTime
                    
                };
                await _context.TblTradeOfferSetupHeader.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var JournalRows = new List<TblTradeOfferSetupRow>(postTradeOfferSetupHeadercommon.TradeOfferSetupRow.Count);
                foreach (var datas in postTradeOfferSetupHeadercommon.TradeOfferSetupRow)
                {
                    TblTradeOfferSetupRow detalisrow = new TblTradeOfferSetupRow { };

                    detalisrow.IntTradeOfferConditionId = detalis.IntTradeOfferConditionId;
                    detalisrow.IntClientId = datas.ClientId;
                    detalisrow.IntBusinessUnitId = datas.BusinessUnitId;
                    detalisrow.IsValueBase = datas.ValueBase;
                    detalisrow.IsSlabProgram = datas.SlabProgram;
                    detalisrow.NumBaseFrom = datas.BaseFrom;
                    detalisrow.NumBaseTo = datas.BaseTo;
                    detalisrow.NumOfferPercent = datas.OfferPercent;
                    detalisrow.NumOfferAmount = datas.OfferAmount;
                    detalisrow.IntOfferItemId = datas.OfferItemId;
                    detalisrow.IntOfferItemUom = datas.OfferItemUom;
                    detalisrow.NumOfferQuantity = datas.OfferQuantity;
                    detalisrow.IntActionBy = datas.ActionBy;
                    detalisrow.DteLastActionDateTime = datas.LastActionDateTime;

                    JournalRows.Add(detalisrow);
                }

                await _context.TblTradeOfferSetupRow.AddRangeAsync(JournalRows);
                await _context.SaveChangesAsync();

                var detalisView = from trs in _context.TblTradeOfferSetupHeader
                                  join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                                  join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                                  where trs.IsActive == true && trs.IntTradeOfferConditionId == detalis.IntTradeOfferConditionId
                                  select new GetTradeOfferSetupHeaderDTO()
                                  {
                                      TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                      ClientId = cl.IntClientId,
                                      ClientName = cl.StrClientName,
                                      BusinessUnitId = trs.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                      PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                      PriceConditionReffId = trs.IntPriceConditionReffId,
                                      TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                      TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                      TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                      RoundingTypeId = trs.IntRoundingTypeId,
                                      RoundingTypeName = rt.StrRoundingTypeName,
                                      MinimumApplied = trs.IsMinimumApplied,
                                      ValueBase = trs.IsValueBase,
                                      SlabProgram = trs.IsSlabProgram,
                                      StartDate = trs.DteStartDate,
                                      EndDate = trs.DteEndDate,
                                      ActionBy = trs.IntActionBy,
                                      LastActionDateTime = trs.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header Created Successfully.",
                    data = detalisView
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }
        public async Task<object> CancelTradeOfferSetupHeader(CancelTradeOfferSetupHeaderDTO TradeOfferSetupHeader)
        {
            try
            {
                TblTradeOfferSetupHeader data = _context.TblTradeOfferSetupHeader.First(x => x.IntTradeOfferConditionId == TradeOfferSetupHeader.TradeOfferConditionId);

                data.IntTradeOfferConditionId = TradeOfferSetupHeader.TradeOfferConditionId;
                data.IntActionBy = TradeOfferSetupHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblTradeOfferSetupHeader.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from trs in _context.TblTradeOfferSetupHeader
                              join b in _context.TblBusinessUnit on trs.IntBusinessUnitId equals b.IntBusinessUnitId
                              join rt in _context.TblRoundingType on trs.IntRoundingTypeId equals rt.IntRoundingTypeId
                              join cl in _context.TblClient on trs.IntClientId equals cl.IntClientId
                              where trs.IsActive == false && trs.IntTradeOfferConditionId == TradeOfferSetupHeader.TradeOfferConditionId
                              select new GetTradeOfferSetupHeaderDTO()
                              {
                                  TradeOfferConditionId = trs.IntTradeOfferConditionId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = trs.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PriceConditionTypeId = trs.IntPriceConditionTypeId,
                                  PriceConditionTypeName = trs.StrPriceConditionTypeName,
                                  PriceConditionReffId = trs.IntPriceConditionReffId,
                                  TradeOfferConditionTypeId = trs.IntTradeOfferConditionTypeId,
                                  TradeOfferConditionTypeName = trs.StrTradeOfferConditionTypeName,
                                  TradeOfferConditionReffId = trs.IntTradeOfferConditionReffId,
                                  RoundingTypeId = trs.IntRoundingTypeId,
                                  RoundingTypeName = rt.StrRoundingTypeName,
                                  MinimumApplied = trs.IsMinimumApplied,
                                  ValueBase = trs.IsValueBase,
                                  SlabProgram = trs.IsSlabProgram,
                                  StartDate = trs.DteStartDate,
                                  EndDate = trs.DteEndDate,
                                  ActionBy = trs.IntActionBy,
                                  LastActionDateTime = trs.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Trade Offer Setup Header Cancelled Successfully.",
                    data = detalis
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }
    }
}
