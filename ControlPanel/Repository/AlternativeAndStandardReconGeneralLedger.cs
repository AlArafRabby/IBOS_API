using ControlPanel.DTO.AlternativeAndStandardReconGeneralLedger;
using ControlPanel.DbContexts;
using ControlPanel.IRepository;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControlPanel.Models.iBOS;

namespace ControlPanel.Repository
{
    public class AlternativeAndStandardReconGeneralLedger : IAlternativeAndStandardReconGeneralLedger
    {
        public readonly iBOSContext _context;
        public AlternativeAndStandardReconGeneralLedger(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAlternativeAndStandardReconGeneralLedgerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All AlternativeAndStandardReconGeneralLedger List ",
                    data = await Task.FromResult((from a in _context.TblAlternativeAndStandardReconGeneralLedger
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  where a.IsActive == true
                                                  select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      AlternateGeneralLedgerId =a.IntAlternateGeneralLedgerId,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetAlternativeAndStandardReconGeneralLedgerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AlternativeAndStandardReconGeneralLedger List by Client Id.",
                    data = await Task.FromResult((from a in _context.TblAlternativeAndStandardReconGeneralLedger
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  where a.IsActive == true && a.IntClientId == CId
                                                  select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetAlternativeAndStandardReconGeneralLedgerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AlternativeAndStandardReconGeneralLedger List by ID.",
                    data = await Task.FromResult((from a in _context.TblAlternativeAndStandardReconGeneralLedger
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  where a.IsActive == true && a.IntConfigId == Id
                                                  select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetAlternativeAndStandardReconGeneralLedgerByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "AlternativeAndStandardReconGeneralLedger List by Unit Id ",
                    data = await Task.FromResult((from a in _context.TblAlternativeAndStandardReconGeneralLedger
                                                  join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  where a.IsActive == true && a.IntBusinessUnitId == UId
                                                  select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                                                  {
                                                      ConfigId = a.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      GeneralLedgerId = gl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<object> CreateAlternativeAndStandardReconGeneralLedger(CreateAlternativeAndStandardReconGeneralLedgerDTO postAlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                var detalis = new TblAlternativeAndStandardReconGeneralLedger
                {
                    IntClientId = postAlternativeAndStandardReconGeneralLedger.ClientId,
                    IntBusinessUnitId = postAlternativeAndStandardReconGeneralLedger.BusinessUnitId,
                    IntGeneralLedgerId = postAlternativeAndStandardReconGeneralLedger.GeneralLedgerId,
                    IntAlternateGeneralLedgerId = postAlternativeAndStandardReconGeneralLedger.AlternateGeneralLedgerId,
                    IntActionBy = postAlternativeAndStandardReconGeneralLedger.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblAlternativeAndStandardReconGeneralLedger.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblAlternativeAndStandardReconGeneralLedger
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              where a.IsActive == true && a.IntConfigId == detalis.IntConfigId
                              select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                              {
                                  ConfigId = a.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  GeneralLedgerId = gl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Alternative And Standard ReconGeneral Ledger Created Successfully.",
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
        public async Task<object> EditAlternativeAndStandardReconGeneralLedger(EditAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                TblAlternativeAndStandardReconGeneralLedger data = _context.TblAlternativeAndStandardReconGeneralLedger.First(x => x.IntConfigId == AlternativeAndStandardReconGeneralLedger.ConfigId);

                data.IntConfigId = AlternativeAndStandardReconGeneralLedger.ConfigId;
                data.IntClientId = AlternativeAndStandardReconGeneralLedger.ClientId;
                data.IntGeneralLedgerId = AlternativeAndStandardReconGeneralLedger.GeneralLedgerId;
                data.IntAlternateGeneralLedgerId = AlternativeAndStandardReconGeneralLedger.AlternateGeneralLedgerId;
                data.IntActionBy = AlternativeAndStandardReconGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblAlternativeAndStandardReconGeneralLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblAlternativeAndStandardReconGeneralLedger
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              where a.IsActive == true && a.IntConfigId == AlternativeAndStandardReconGeneralLedger.ConfigId
                              select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                              {
                                  ConfigId = a.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  GeneralLedgerId = gl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Alternative And Standard ReconGeneral Ledger Edited Successfully.",
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
        public async Task<object> CancelAlternativeAndStandardReconGeneralLedger(CancelAlternativeAndStandardReconGeneralLedgerDTO AlternativeAndStandardReconGeneralLedger)
        {
            try
            {
                TblAlternativeAndStandardReconGeneralLedger data = _context.TblAlternativeAndStandardReconGeneralLedger.First(x => x.IntConfigId == AlternativeAndStandardReconGeneralLedger.ConfigId);
                data.IntActionBy = AlternativeAndStandardReconGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblAlternativeAndStandardReconGeneralLedger.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblAlternativeAndStandardReconGeneralLedger
                              join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on a.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              where a.IsActive == false && a.IntConfigId == AlternativeAndStandardReconGeneralLedger.ConfigId
                              select new GetAlternativeAndStandardReconGeneralLedgerDTO()
                              {
                                  ConfigId = a.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  GeneralLedgerId = gl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  AlternateGeneralLedgerId = a.IntAlternateGeneralLedgerId,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Alternative And Standard ReconGeneral Ledger Cancelled Successfully.",
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
