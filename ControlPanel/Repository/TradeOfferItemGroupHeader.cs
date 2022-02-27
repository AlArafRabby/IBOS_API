using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using ControlPanel.DTO.TradeOfferItemGroupHeader;
using ControlPanel.DbContexts;

namespace ControlPanel.Repository
{
    public class TradeOfferItemGroupHeader : ITradeOfferItemGroupHeader
    {
        public readonly iBOSContext _context;
        public TradeOfferItemGroupHeader(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTradeOfferItemGroupHeaderById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header List By Id.",
                    data = await Task.FromResult((from toh in _context.TblTradeOfferItemGroupHeader
                                                  join b in _context.TblBusinessUnit on toh.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on toh.IntClientId equals cl.IntClientId
                                                  where toh.IsActive == true && toh.IntTradeOfferItemGroupId == Id
                                                  select new GetTradeOfferItemGroupHeaderDTO()
                                                  {
                                                      TradeOfferItemGroupId = toh.IntTradeOfferItemGroupId,
                                                      TradeOfferItemGroupName = toh.StrTradeOfferItemGroupName,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = toh.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = toh.IntActionBy,
                                                      LastActionDateTime = toh.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferItemGroupHeaderByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header List By Client Id.",
                    data = await Task.FromResult((from toh in _context.TblTradeOfferItemGroupHeader
                                                  join b in _context.TblBusinessUnit on toh.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on toh.IntClientId equals cl.IntClientId
                                                  where toh.IsActive == true && toh.IntClientId == CId
                                                  select new GetTradeOfferItemGroupHeaderDTO()
                                                  {
                                                      TradeOfferItemGroupId = toh.IntTradeOfferItemGroupId,
                                                      TradeOfferItemGroupName = toh.StrTradeOfferItemGroupName,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = toh.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = toh.IntActionBy,
                                                      LastActionDateTime = toh.DteLastActionDateTime

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
        public async Task<Message> GetTradeOfferItemGroupHeaderByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header List By Unit Id.",
                    data = await Task.FromResult((from toh in _context.TblTradeOfferItemGroupHeader
                                                  join b in _context.TblBusinessUnit on toh.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join cl in _context.TblClient on toh.IntClientId equals cl.IntClientId
                                                  where toh.IsActive == true && toh.IntBusinessUnitId == UId
                                                  select new GetTradeOfferItemGroupHeaderDTO()
                                                  {
                                                      TradeOfferItemGroupId = toh.IntTradeOfferItemGroupId,
                                                      TradeOfferItemGroupName = toh.StrTradeOfferItemGroupName,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = toh.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ActionBy = toh.IntActionBy,
                                                      LastActionDateTime = toh.DteLastActionDateTime

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
        public async Task<object> CreateTradeOfferItemGroupHeader(CreateTradeOfferItemGroupHeaderCommon TradeOfferItemGroupHeaderCommons)
        {
            try
            {
                var detalis = new TblTradeOfferItemGroupHeader
                {
                    StrTradeOfferItemGroupName = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.TradeOfferItemGroupName,
                    IntClientId = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.ClientId,
                    IntBusinessUnitId = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.BusinessUnitId,
                    IntActionBy = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.ActionBy,
                    DteLastActionDateTime = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.LastActionDateTime
                };
                await _context.TblTradeOfferItemGroupHeader.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisrow = new TblTradeOfferItemGroupRow { };

                foreach (var datas in TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupRow)
                {
                    detalisrow.IntTradeOfferItemGroupId = detalis.IntTradeOfferItemGroupId;
                    detalisrow.IntItemId = datas.ItemId;
                    detalisrow.IntBusinessUnitId = datas.BusinessUnitId; 
                }

                await _context.TblTradeOfferItemGroupRow.AddAsync(detalisrow);
                await _context.SaveChangesAsync();

                var detalisView = from toh in _context.TblTradeOfferItemGroupHeader
                                    join b in _context.TblBusinessUnit on toh.IntBusinessUnitId equals b.IntBusinessUnitId
                                    join cl in _context.TblClient on toh.IntClientId equals cl.IntClientId
                                    where toh.IsActive == true && toh.IntTradeOfferItemGroupId == detalis.IntTradeOfferItemGroupId
                                    select new GetTradeOfferItemGroupHeaderDTO()
                                    {
                                        TradeOfferItemGroupId = toh.IntTradeOfferItemGroupId,
                                        TradeOfferItemGroupName = toh.StrTradeOfferItemGroupName,
                                        ClientId = cl.IntClientId,
                                        ClientName = cl.StrClientName,
                                        BusinessUnitId = toh.IntBusinessUnitId,
                                        BusinessUnitName = b.StrBusinessUnitName,
                                        ActionBy = toh.IntActionBy,
                                        LastActionDateTime = toh.DteLastActionDateTime

                                    };

                var successmsg = new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header Created Successfully.",
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
        public async Task<object> EditTradeOfferItemGroupHeader(EditTradeOfferItemGroupHeaderCommon TradeOfferItemGroupHeaderCommons)
        {
            try
            {
                TblTradeOfferItemGroupHeader data = _context.TblTradeOfferItemGroupHeader.First(x => x.IntTradeOfferItemGroupId == TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.TradeOfferGroupId);
                data.StrTradeOfferItemGroupName = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.TradeOfferItemGroupName;
                data.IntActionBy = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblTradeOfferItemGroupHeader.Update(data);
                await _context.SaveChangesAsync();

                var detalisrow = new TblTradeOfferItemGroupRow { };

                foreach (var datas in TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupRow)
                {

                    TblTradeOfferItemGroupRow rdata = _context.TblTradeOfferItemGroupRow.First(x => x.IntRowId == datas.rowid);
                    data.StrTradeOfferItemGroupName = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.TradeOfferItemGroupName;
                    data.IntActionBy = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader.ActionBy;
                    data.DteLastActionDateTime = DateTime.UtcNow;
                    _context.TblTradeOfferItemGroupRow.Update(rdata);
                    await _context.SaveChangesAsync();
                }
                var successmsg = new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header Edited Successfully.",
                    data = TradeOfferItemGroupHeaderCommons.TradeOfferItemGroupHeader
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
        public async Task<object> CancelTradeOfferItemGroupHeader(CancelTradeOfferItemGroupHeaderDTO TradeOfferItemGroupHeader)
        {
            try
            {
                TblTradeOfferItemGroupHeader data = _context.TblTradeOfferItemGroupHeader.First(x => x.IntTradeOfferItemGroupId == TradeOfferItemGroupHeader.TradeOfferItemGroupId);

                data.IntActionBy = TradeOfferItemGroupHeader.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblTradeOfferItemGroupHeader.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from toh in _context.TblTradeOfferItemGroupHeader
                              join b in _context.TblBusinessUnit on toh.IntBusinessUnitId equals b.IntBusinessUnitId
                              join cl in _context.TblClient on toh.IntClientId equals cl.IntClientId
                              where toh.IsActive == false && toh.IntTradeOfferItemGroupId == TradeOfferItemGroupHeader.TradeOfferItemGroupId
                              select new GetTradeOfferItemGroupHeaderDTO()
                              {
                                  TradeOfferItemGroupId = toh.IntTradeOfferItemGroupId,
                                  TradeOfferItemGroupName = toh.StrTradeOfferItemGroupName,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = toh.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ActionBy = toh.IntActionBy,
                                  LastActionDateTime = toh.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Trade Offer Item Group Header Cancelled Successfully.",
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
