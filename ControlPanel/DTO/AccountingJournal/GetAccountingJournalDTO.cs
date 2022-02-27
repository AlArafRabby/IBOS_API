using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingJournal
{
    public class GetAccountingJournalDTO
    {
        [Required]
        public long TrasactionId { get; set; }
        public long ClientId { get; set; }
        public long BusinessUnitId { get; set; }
        public long BusinessAreaId { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public long AccountingJournalId { get; set; }
        public string AccountingJournalCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public long GeneralLedgerId { get; set; }
        public string GeneralLedgerCode { get; set; }
        public string GeneralLedgerName { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
