using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerLedger;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessPartnerLedger : IBusinessPartnerLedger
    {
        public readonly iBOSContext _context;
        public BusinessPartnerLedger(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerLedgerById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Ledger List By Id.",
                    data = await Task.FromResult((from bpl in _context.TblBusinessPartnerLedger
                                                  join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                                                  join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                                                  where bpl.IsActive == true && bpl.IntTransactionId == Id
                                                  select new GetBusinessPartnerLedgerDTO()
                                                  {
                                                      TransactionId = bpl.IntTransactionId,
                                                      TransactionDate = bpl.DteTransactionDate,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bpl.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ba.IntBusinessAreaId,
                                                      BusinessAreaName = ba.StrBusinessAreaName,
                                                      AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                                      Amount = bpl.NumAmount,
                                                      RunningAmount = bpl.NumRunningAmount,
                                                      Narration = bpl.StrNarration,
                                                      AccountingJournalId = bpl.IntAccountingJournalId,
                                                      ActionBy = bpl.IntActionBy,
                                                      LastActionDateTime = bpl.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerLedgerByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "BusinessPartnerLedger List By Client Id.",
                    data = await Task.FromResult((from bpl in _context.TblBusinessPartnerLedger
                                                  join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                                                  join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                                                  where bpl.IsActive == true && bpl.IntClientId == CId
                                                  select new GetBusinessPartnerLedgerDTO()
                                                  {
                                                      TransactionId = bpl.IntTransactionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bpl.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ba.IntBusinessAreaId,
                                                      BusinessAreaName = ba.StrBusinessAreaName,
                                                      AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                                      Amount = bpl.NumAmount,
                                                      RunningAmount = bpl.NumRunningAmount,
                                                      Narration = bpl.StrNarration,
                                                      AccountingJournalId = bpl.IntAccountingJournalId,
                                                      ActionBy = bpl.IntActionBy,
                                                      LastActionDateTime = bpl.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerLedgerByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "BusinessPartnerLedger List By Unit Id.",
                    data = await Task.FromResult((from bpl in _context.TblBusinessPartnerLedger
                                                  join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                                                  join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                                                  where bpl.IsActive == true && bpl.IntBusinessUnitId == UId
                                                  select new GetBusinessPartnerLedgerDTO()
                                                  {
                                                      TransactionId = bpl.IntTransactionId,
                                                      ClientId = cl.IntClientId,
                                                      ClientName = cl.StrClientName,
                                                      BusinessUnitId = bpl.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ba.IntBusinessAreaId,
                                                      BusinessAreaName = ba.StrBusinessAreaName,
                                                      AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                                      AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                                      Amount = bpl.NumAmount,
                                                      RunningAmount = bpl.NumRunningAmount,
                                                      Narration = bpl.StrNarration,
                                                      AccountingJournalId = bpl.IntAccountingJournalId,
                                                      ActionBy = bpl.IntActionBy,
                                                      LastActionDateTime = bpl.DteLastActionDateTime

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
        public async Task<object> CreateBusinessPartnerLedger(CreateBusinessPartnerLedgerDTO postBusinessPartnerLedger)
        {
            try
            {
                var detalis = new TblBusinessPartnerLedger
                {
                    DteTransactionDate = DateTime.UtcNow,
                    IntClientId = postBusinessPartnerLedger.ClientId,
                    IntBusinessUnitId = postBusinessPartnerLedger.BusinessUnitId,
                    IntBusinessAreaId = postBusinessPartnerLedger.BusinessAreaId,
                    IntBusinessPartnerId = postBusinessPartnerLedger.BusinessPartnerId,
                    IntAccountingJournalTypeId = postBusinessPartnerLedger.AccountingJournalTypeId,
                    StrAccountingJournalTypeName = postBusinessPartnerLedger.AccountingJournalTypeName,
                    NumAmount = postBusinessPartnerLedger.Amount,
                    NumRunningAmount = postBusinessPartnerLedger.RunningAmount,
                    StrNarration = postBusinessPartnerLedger.Narration,
                    IntAccountingJournalId = postBusinessPartnerLedger.AccountingJournalId,
                    IntActionBy = postBusinessPartnerLedger.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblBusinessPartnerLedger.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bpl in _context.TblBusinessPartnerLedger
                              join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                              join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                              join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                              where bpl.IsActive == true && bpl.IntTransactionId == detalis.IntTransactionId
                              select new GetBusinessPartnerLedgerDTO()
                              {
                                  TransactionId = bpl.IntTransactionId,
                                  TransactionDate = bpl.DteTransactionDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bpl.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = ba.IntBusinessAreaId,
                                  BusinessAreaName = ba.StrBusinessAreaName,
                                  AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                  Amount = bpl.NumAmount,
                                  RunningAmount = bpl.NumRunningAmount,
                                  Narration = bpl.StrNarration,
                                  AccountingJournalId = bpl.IntAccountingJournalId,
                                  ActionBy = bpl.IntActionBy,
                                  LastActionDateTime = bpl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Ledger Created Successfully.",
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
        public async Task<object> EditBusinessPartnerLedger(EditBusinessPartnerLedgerDTO BusinessPartnerLedger)
        {
            try
            {
                TblBusinessPartnerLedger data = _context.TblBusinessPartnerLedger.First(x => x.IntTransactionId == BusinessPartnerLedger.TransactionId);

                data.IntTransactionId = BusinessPartnerLedger.TransactionId;
                data.DteTransactionDate = BusinessPartnerLedger.TransactionDate;
                data.IntClientId = BusinessPartnerLedger.ClientId;
                data.IntBusinessUnitId = BusinessPartnerLedger.BusinessUnitId;
                data.IntBusinessAreaId = BusinessPartnerLedger.BusinessAreaId;
                data.IntBusinessPartnerId = BusinessPartnerLedger.BusinessPartnerId;
                data.IntActionBy = BusinessPartnerLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessPartnerLedger.Update(data);
                await _context.SaveChangesAsync();
                
                var detalis = from bpl in _context.TblBusinessPartnerLedger
                              join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                              join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                              join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                              where bpl.IsActive == true && bpl.IntTransactionId == BusinessPartnerLedger.TransactionId
                              select new GetBusinessPartnerLedgerDTO()
                              {
                                  TransactionId = bpl.IntTransactionId,
                                  TransactionDate = bpl.DteTransactionDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bpl.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = ba.IntBusinessAreaId,
                                  BusinessAreaName = ba.StrBusinessAreaName,
                                  AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                  Amount = bpl.NumAmount,
                                  RunningAmount = bpl.NumRunningAmount,
                                  Narration = bpl.StrNarration,
                                  AccountingJournalId = bpl.IntAccountingJournalId,
                                  ActionBy = bpl.IntActionBy,
                                  LastActionDateTime = bpl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Ledger Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerLedger(CancelBusinessPartnerLedgerDTO BusinessPartnerLedger)
        {
            try
            {
                TblBusinessPartnerLedger data = _context.TblBusinessPartnerLedger.First(x => x.IntTransactionId == BusinessPartnerLedger.TransactionId);

                data.IntActionBy = BusinessPartnerLedger.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerLedger.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bpl in _context.TblBusinessPartnerLedger
                              join b in _context.TblBusinessUnit on bpl.IntBusinessUnitId equals b.IntBusinessUnitId
                              join ba in _context.TblBusinessArea on bpl.IntBusinessAreaId equals ba.IntBusinessAreaId
                              join cl in _context.TblClient on bpl.IntClientId equals cl.IntClientId
                              where bpl.IsActive == false && bpl.IntTransactionId == BusinessPartnerLedger.TransactionId
                              select new GetBusinessPartnerLedgerDTO()
                              {
                                  TransactionId = bpl.IntTransactionId,
                                  TransactionDate = bpl.DteTransactionDate,
                                  ClientId = cl.IntClientId,
                                  ClientName = cl.StrClientName,
                                  BusinessUnitId = bpl.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = ba.IntBusinessAreaId,
                                  BusinessAreaName = ba.StrBusinessAreaName,
                                  AccountingJournalTypeId = bpl.IntAccountingJournalTypeId,
                                  AccountingJournalTypeName = bpl.StrAccountingJournalTypeName,
                                  Amount = bpl.NumAmount,
                                  RunningAmount = bpl.NumRunningAmount,
                                  Narration = bpl.StrNarration,
                                  AccountingJournalId = bpl.IntAccountingJournalId,
                                  ActionBy = bpl.IntActionBy,
                                  LastActionDateTime = bpl.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Ledger Cancelled Successfully.",
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
