using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingJournal;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class AccountingJournal : IAccountingJournal
    {
        public readonly iBOSContext _context;
        public AccountingJournal(iBOSContext context)
        {
            _context = context;
        }
        public async Task<object> CreateAccountingJournalVoucher(CreateAccountingJournalDTO postAccountingJournal)
        {
            try
            {
                var detalis = new TblAccountingJournal
                {
                    IntClientId = postAccountingJournal.ClientId,
                    IntBusinessUnitId = postAccountingJournal.BusinessUnitId,
                    IntBusinessAreaId = postAccountingJournal.BusinessAreaId,
                    IntAccountingJournalTypeId = postAccountingJournal.AccountingJournalTypeId,
                    IntAccountingJournalId = postAccountingJournal.AccountingJournalId,
                    StrAccountingJournalCode = postAccountingJournal.AccountingJournalCode,
                    DteTransactionDate = postAccountingJournal.TransactionDate,
                    IntGeneralLedgerId = postAccountingJournal.GeneralLedgerId,
                    StrGeneralLedgerCode = postAccountingJournal.GeneralLedgerCode,
                    StrGeneralLedgerName = postAccountingJournal.GeneralLedgerName,
                    NumAmount = postAccountingJournal.Amount,
                    StrNarration = postAccountingJournal.Narration,
                    IntActionBy = postAccountingJournal.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };

                await _context.TblAccountingJournal.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var successmsg = new Message
                {
                    status = true,
                    message = "Accounting Journal Voucher Created Successfully.",
                    data = postAccountingJournal
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
