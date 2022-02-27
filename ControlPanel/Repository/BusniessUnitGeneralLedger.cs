using ControlPanel.DTO.BusniessUnitGeneralLedger;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DbContexts;

namespace ControlPanel.Repository
{
    public class BusniessUnitGeneralLedger : IBusniessUnitGeneralLedger
    {
        public readonly iBOSContext _context;
        public BusniessUnitGeneralLedger(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusniessUnitGeneralLedgerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Busniess Unit General Ledger List ",
                    data = await Task.FromResult((from bgl in _context.TblBusniessUnitGeneralLedger
                                                  join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true
                                                  select new GetBusniessUnitGeneralLedgerDTO()
                                                  {
                                                      AutoId=bgl.IntAutoId,
                                                      ClientId=bgl.IntClientId, 
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName= bu.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      CurrentBalance = bgl.NumCurrentBalance,
                                                      LastActionDateTime = bgl.DteLastActionDateTime,
                                                      ActionBy = bgl.IntActionBy

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
        public async Task<Message> GetBusniessUnitGeneralLedgerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Busniess Unit General Ledger List by Id ",
                    data = await Task.FromResult((from bgl in _context.TblBusniessUnitGeneralLedger
                                                  join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive==true && bgl.IntGeneralLedgerId==Id
                                                  select new GetBusniessUnitGeneralLedgerDTO()
                                                  {
                                                      AutoId = bgl.IntAutoId,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      CurrentBalance = bgl.NumCurrentBalance,
                                                      LastActionDateTime = bgl.DteLastActionDateTime,
                                                      ActionBy = bgl.IntActionBy

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
        public async Task<Message> GetBusniessUnitGeneralLedgerByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Busniess Unit General Ledger List by Unit Id ",
                    data = await Task.FromResult((from bgl in _context.TblBusniessUnitGeneralLedger
                                                  join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true && bgl.IntBusinessUnitId == UId
                                                  select new GetBusniessUnitGeneralLedgerDTO()
                                                  {
                                                      AutoId = bgl.IntAutoId,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      CurrentBalance = bgl.NumCurrentBalance,
                                                      LastActionDateTime = bgl.DteLastActionDateTime,
                                                      ActionBy = bgl.IntActionBy

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
        public async Task<Message> GetBusniessUnitGeneralLedgerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Busniess Unit General Ledger List by Client Id ",
                    data = await Task.FromResult((from bgl in _context.TblBusniessUnitGeneralLedger
                                                  join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                                                  where bgl.IsActive == true && bgl.IntClientId == CId
                                                  select new GetBusniessUnitGeneralLedgerDTO()
                                                  {
                                                      AutoId = bgl.IntAutoId,
                                                      ClientId = bgl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      CurrentBalance = bgl.NumCurrentBalance,
                                                      LastActionDateTime = bgl.DteLastActionDateTime,
                                                      ActionBy = bgl.IntActionBy

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
        public async Task<object> CreateBusniessUnitGeneralLedger(CreateBusniessUnitGeneralLedgerDTO postBusniessUnitGeneralLedger)
        {
            try
            {
                var detalis = new TblBusniessUnitGeneralLedger
                {
                    IntClientId = postBusniessUnitGeneralLedger.ClientId,
                    IntBusinessUnitId = postBusniessUnitGeneralLedger.BusinessUnitId,
                    IntGeneralLedgerId = postBusniessUnitGeneralLedger.GeneralLedgerId,
                    NumCurrentBalance = postBusniessUnitGeneralLedger.CurrentBalance,
                    IntActionBy = postBusniessUnitGeneralLedger.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBusniessUnitGeneralLedger.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisViews = from bgl in _context.TblBusniessUnitGeneralLedger
                                  join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                  join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                  join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                                  where bgl.IsActive == true && bgl.IntGeneralLedgerId == detalis.IntGeneralLedgerId
                                  select new GetBusniessUnitGeneralLedgerDTO()
                                  {
                                      AutoId = bgl.IntAutoId,
                                      ClientId = bgl.IntClientId,
                                      ClientName = cl.StrClientName,
                                      BusinessUnitId = bu.IntBusinessUnitId,
                                      BusinessUnitName = bu.StrBusinessUnitName,
                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                      CurrentBalance = bgl.NumCurrentBalance,
                                      LastActionDateTime = bgl.DteLastActionDateTime,
                                      ActionBy = bgl.IntActionBy

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Busniess Unit General Ledger Created Successfully.",
                    data = detalisViews
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
        public async Task<object> EditBusniessUnitGeneralLedger(EditBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger)
        {
            try
            {
                TblBusniessUnitGeneralLedger data = _context.TblBusniessUnitGeneralLedger.First(x => x.IntGeneralLedgerId == BusniessUnitGeneralLedger.GeneralLedgerId && x.IntAutoId== BusniessUnitGeneralLedger.AutoId);
               
                data.IntClientId = BusniessUnitGeneralLedger.ClientId;
                data.IntGeneralLedgerId = BusniessUnitGeneralLedger.GeneralLedgerId;
                data.NumCurrentBalance = BusniessUnitGeneralLedger.CurrentBalance;
                data.IntActionBy = BusniessUnitGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusniessUnitGeneralLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblBusniessUnitGeneralLedger
                              join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                              where bgl.IsActive == true && bgl.IntGeneralLedgerId == BusniessUnitGeneralLedger.GeneralLedgerId
                              select new GetBusniessUnitGeneralLedgerDTO()
                              {
                                  AutoId = bgl.IntAutoId,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  GeneralLedgerId = gl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  CurrentBalance = bgl.NumCurrentBalance,
                                  LastActionDateTime = bgl.DteLastActionDateTime,
                                  ActionBy = bgl.IntActionBy

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Busniess Unit General Ledger Edited Successfully.",
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
        public async Task<object> CancelBusniessUnitGeneralLedger(CancelBusniessUnitGeneralLedgerDTO BusniessUnitGeneralLedger)
        {
            try
            {
                TblBusniessUnitGeneralLedger data = _context.TblBusniessUnitGeneralLedger.First(x => x.IntAutoId == BusniessUnitGeneralLedger.AutoId);

                data.IntAutoId = BusniessUnitGeneralLedger.AutoId;
                data.IntActionBy = BusniessUnitGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusniessUnitGeneralLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bgl in _context.TblBusniessUnitGeneralLedger
                              join gl in _context.TblGeneralLedger on bgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join bu in _context.TblBusinessUnit on bgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join cl in _context.TblClient on bu.IntClientId equals cl.IntClientId
                              where bgl.IsActive == false &&  bgl.IntAutoId == BusniessUnitGeneralLedger.AutoId
                              select new GetBusniessUnitGeneralLedgerDTO()
                              {
                                  AutoId = bgl.IntAutoId,
                                  ClientId = bgl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  GeneralLedgerId = gl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  CurrentBalance = bgl.NumCurrentBalance,
                                  LastActionDateTime = bgl.DteLastActionDateTime,
                                  ActionBy = bgl.IntActionBy

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Busniess Unit General Ledger Cancelled Successfully.",
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
