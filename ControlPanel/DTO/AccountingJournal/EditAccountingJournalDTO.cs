using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingJournal
{
    public class EditAccountingJournalDTO
    {
        [Required]
        public long TrasactionId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public long AccountingJournalId { get; set; }
        [Required]
        public string AccountingJournalCode { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public string GeneralLedgerCode { get; set; }
        [Required]
        public string GeneralLedgerName { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
