using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerGeneralLedger;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessPartnerGeneralLedger : IBusinessPartnerGeneralLedger
    {

        public readonly iBOSContext _context;
        public BusinessPartnerGeneralLedger(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerGeneralLedgerAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner General Ledger List ",
                    data = await Task.FromResult((from bpgl in _context.TblBusinessPartnerGeneralLedger
                                                  join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                                                  where bu.IsActive == true
                                                  select new GetBusinessPartnerGeneralLedgerDTO()
                                                  {
                                                      ConfigId = bpgl.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId=bpgl.IntGeneralLedgerId,
                                                      GeneralLedgerName=gl.StrGeneralLedgerName,
                                                      BusinessPartnerId=bpgl.IntBusinessPartnerId,
                                                      BusinessPartnerName=bp.StrBusinessPartnerName,
                                                      ActionBy=bpgl.IntActionBy,
                                                      LastActionDateTime = bpgl.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerGeneralLedgerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner General Ledger List By Id",
                    data = await Task.FromResult((from bpgl in _context.TblBusinessPartnerGeneralLedger
                                                  join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                                                  where bu.IsActive == true
                                                  select new GetBusinessPartnerGeneralLedgerDTO()
                                                  {
                                                      ConfigId = bpgl.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      ActionBy = bpgl.IntActionBy,
                                                      LastActionDateTime = bpgl.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerGeneralLedgerByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner General Ledger List By Unit Id ",
                    data = await Task.FromResult((from bpgl in _context.TblBusinessPartnerGeneralLedger
                                                  join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                                                  where bu.IsActive == true
                                                  select new GetBusinessPartnerGeneralLedgerDTO()
                                                  {
                                                      ConfigId = bpgl.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      ActionBy = bpgl.IntActionBy,
                                                      LastActionDateTime = bpgl.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerGeneralLedgerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner General Ledger List By Client Id ",
                    data = await Task.FromResult((from bpgl in _context.TblBusinessPartnerGeneralLedger
                                                  join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                                                  join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                                                  where bu.IsActive == true
                                                  select new GetBusinessPartnerGeneralLedgerDTO()
                                                  {
                                                      ConfigId = bpgl.IntConfigId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessName = bu.StrBusinessUnitName,
                                                      GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                                      GeneralLedgerName = gl.StrGeneralLedgerName,
                                                      BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      ActionBy = bpgl.IntActionBy,
                                                      LastActionDateTime = bpgl.DteLastActionDateTime

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
        public async Task<object> CreateBusinessPartnerGeneralLedger(CreateBusinessPartnerGeneralLedgerDTO postBusinessPartnerGeneralLedger)
        {
            try
            {
                var detalis = new TblBusinessPartnerGeneralLedger
                {
                    IntClientId = postBusinessPartnerGeneralLedger.ClientId,
                    IntBusinessUnitId = postBusinessPartnerGeneralLedger.BusinessUnitId,
                    IntGeneralLedgerId = postBusinessPartnerGeneralLedger.GeneralLedgerId,
                    IntBusinessPartnerId = postBusinessPartnerGeneralLedger.BusinessPartnerId,
                    IntActionBy = postBusinessPartnerGeneralLedger.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBusinessPartnerGeneralLedger.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bpgl in _context.TblBusinessPartnerGeneralLedger
                              join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                              where bu.IsActive == true && bpgl.IntConfigId == detalis.IntConfigId
                              select new GetBusinessPartnerGeneralLedgerDTO()
                              {
                                  ConfigId = bpgl.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessName = bu.StrBusinessUnitName,
                                  GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bpgl.IntActionBy,
                                  LastActionDateTime = bpgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner General Ledger Created Successfully.",
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
        public async Task<object> EditBusinessPartnerGeneralLedger(EditBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger)
        {
            try
            {
                TblBusinessPartnerGeneralLedger data = _context.TblBusinessPartnerGeneralLedger.First(x => x.IntConfigId == BusinessPartnerGeneralLedger.ConfigId);

                data.IntConfigId = BusinessPartnerGeneralLedger.ConfigId;
                data.IntClientId = BusinessPartnerGeneralLedger.ClientId;
                data.IntBusinessUnitId = BusinessPartnerGeneralLedger.BusinessUnitId;
                data.IntGeneralLedgerId = BusinessPartnerGeneralLedger.GeneralLedgerId;
                data.IntBusinessPartnerId = BusinessPartnerGeneralLedger.BusinessPartnerId;
                data.IntActionBy = BusinessPartnerGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessPartnerGeneralLedger.Update(data);
                await _context.SaveChangesAsync();
                
                var detalis = from bpgl in _context.TblBusinessPartnerGeneralLedger
                              join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                              where bu.IsActive == true && bpgl.IntConfigId == BusinessPartnerGeneralLedger.ConfigId
                              select new GetBusinessPartnerGeneralLedgerDTO()
                              {
                                  ConfigId = bpgl.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessName = bu.StrBusinessUnitName,
                                  GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bpgl.IntActionBy,
                                  LastActionDateTime = bpgl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner General Ledger Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerGeneralLedger(CancelBusinessPartnerGeneralLedgerDTO BusinessPartnerGeneralLedger)
        {
            try
            {
                TblBusinessPartnerGeneralLedger data = _context.TblBusinessPartnerGeneralLedger.First(x => x.IntConfigId == BusinessPartnerGeneralLedger.ConfigId);

                data.IntConfigId = BusinessPartnerGeneralLedger.ConfigId;
                data.IntActionBy = BusinessPartnerGeneralLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblBusinessPartnerGeneralLedger.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from bpgl in _context.TblBusinessPartnerGeneralLedger
                              join bu in _context.TblBusinessUnit on bpgl.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join gl in _context.TblGeneralLedger on bpgl.IntGeneralLedgerId equals gl.IntGeneralLedgerId
                              join bp in _context.TblBusinessPartner on bpgl.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join cl in _context.TblClient on bpgl.IntClientId equals cl.IntClientId
                              where bu.IsActive == false && bpgl.IntConfigId == BusinessPartnerGeneralLedger.ConfigId
                              select new GetBusinessPartnerGeneralLedgerDTO()
                              {
                                  ConfigId = bpgl.IntConfigId,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessName = bu.StrBusinessUnitName,
                                  GeneralLedgerId = bpgl.IntGeneralLedgerId,
                                  GeneralLedgerName = gl.StrGeneralLedgerName,
                                  BusinessPartnerId = bpgl.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  ActionBy = bpgl.IntActionBy,
                                  LastActionDateTime = bpgl.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner General Ledger Cancelled Successfully.",
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
