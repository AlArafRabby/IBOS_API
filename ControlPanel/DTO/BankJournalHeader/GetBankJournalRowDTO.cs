using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class GetBankJournalRowDTO
    {
        public long RowId { get; set; }
        public long BankJournalId { get; set; }
        public string BankJournalCode { get; set; }
        public long GeneralLedgerId { get; set; }
        public string GeneralLedgerCode { get; set; }
        public string GeneralLedgerName { get; set; }
        public decimal Amount { get; set; }
    }
}
