using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountReceivablePayable;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountReceivablePayable : IAccountReceivablePayable
    {
        public readonly iBOSContext _context;
        public AccountReceivablePayable(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetAccountReceivablePayablebyClientIdBusinessUnitId(long ClientId, long BusinessUnitId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Get Account Receivable Payable by ClientId BusinessUnitId ",
                    data = "" /* await Task.FromResult((from arp in _context.TblAccountReceivablePayable                                                
                                                  where arp.IsActive == true && arp.IntClientId == ClientId && arp.IntBusinessUnitId == BusinessUnitId
                                                  select new GetAccountReceivablePayableDTO()
                                                  {
                                                      AccountReceivablePayableId = arp.IntAccountReceivablePayableId,
                                                      ClientId = arp.IntClientId,
                                                      BusinessUnitId = arp.IntBusinessUnitId,
                                                      BusinessAreaId = arp.IntBusinessAreaId,
                                                      BusinessPartnerId = arp.IntBusinessPartnerId,
                                                      InvoiceCode = arp.StrInvoiceCode,
                                                      AdjustmentJournalId = arp.IntAdjustmentJournalId,
                                                      AdjustmentJournalCode = arp.StrAdjustmentJournalCode,
                                                      Amount = arp.NumAmount,
                                                      Narration = arp.StrNarration,
                                                      IsReceivable = arp.IsReceivable,
                                                      PayTerm = arp.IntPayTerm,
                                                      TransactionDate = arp.DteTransactionDate,
                                                      DueDate = arp.DteDueDate,
                                                      Cleared = arp.IsCleared,
                                                      ClearingDate = arp.DteClearingDate,
                                                      ActionBy = arp.IntActionBy,
                                                      DteLastActionDateTime = arp.DteLastActionDateTime
                                                  }).ToList()) */
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
        public async Task<object> CreateAccountReceivablePayableVoucher(CreateAccountReceivablePayableDTO postCreateAccountReceivablePayable)
        {
            try
            {
                var detalis = new TblAccountReceivablePayable
                {
                    IntClientId = postCreateAccountReceivablePayable.ClientId,
                    IntBusinessUnitId = postCreateAccountReceivablePayable.BusinessUnitId,
                    IntBusinessAreaId = postCreateAccountReceivablePayable.BusinessAreaId,
                    IntBusinessPartnerId = postCreateAccountReceivablePayable.BusinessPartnerId,
                    StrInvoiceCode = postCreateAccountReceivablePayable.InvoiceCode,
                    IntAdjustmentJournalId = postCreateAccountReceivablePayable.AdjustmentJournalId,                   
                    StrAdjustmentJournalCode = postCreateAccountReceivablePayable.AdjustmentJournalCode,
                    NumAmount = postCreateAccountReceivablePayable.Amount,
                    StrNarration = postCreateAccountReceivablePayable.Narration,
                    IsReceivable = postCreateAccountReceivablePayable.IsReceivable,
                    IntPayTerm = postCreateAccountReceivablePayable.PayTerm,
                    DteTransactionDate = postCreateAccountReceivablePayable.TransactionDate,
                    DteDueDate = postCreateAccountReceivablePayable.DueDate,
                    IsCleared = postCreateAccountReceivablePayable.Cleared,
                    DteClearingDate = postCreateAccountReceivablePayable.ClearingDate,                   
                    IntActionBy = postCreateAccountReceivablePayable.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
              /*  await _context.TblAccountReceivablePayable.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detailsView = from arp in _context.TblAccountReceivablePayable
                                  where arp.IsActive == true && arp.IntAccountReceivablePayableId == detalis.IntAccountReceivablePayableId
                                  select new GetAccountReceivablePayableDTO()
                                  {
                                      AccountReceivablePayableId = arp.IntAccountReceivablePayableId,
                                      ClientId = arp.IntClientId,
                                      BusinessUnitId = arp.IntBusinessUnitId,
                                      BusinessAreaId = arp.IntBusinessAreaId,
                                      BusinessPartnerId = arp.IntBusinessPartnerId,
                                      InvoiceCode = arp.StrInvoiceCode,
                                      AdjustmentJournalId = arp.IntAdjustmentJournalId,
                                      AdjustmentJournalCode = arp.StrAdjustmentJournalCode,
                                      Amount = arp.NumAmount,
                                      Narration = arp.StrNarration,
                                      IsReceivable = arp.IsReceivable,
                                      PayTerm = arp.IntPayTerm,
                                      TransactionDate = arp.DteTransactionDate,
                                      DueDate = arp.DteDueDate,
                                      Cleared = arp.IsCleared,
                                      ClearingDate = arp.DteClearingDate,
                                      ActionBy = arp.IntActionBy,
                                      DteLastActionDateTime = arp.DteLastActionDateTime
                                  };
                                  */
                var successmsg = new Message
                {
                    status = true,
                    message = "Account Receivable Payable Voucher Created Successfully.",
                    data = ""//detailsView
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
