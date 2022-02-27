using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class CreateAccountReceivablePayableHeaderDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public string InvoiceCode { get; set; }
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public bool IsReceivable { get; set; }
        [Required]
        public long PayTerm { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public bool IsCleared { get; set; }
        [Required]
        public DateTime? ClearingDate { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
