using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class GetAccountReceivablePayableHeaderDTO
    {
        [Required]
        public long AccountReceivablePayableId { get; set; }        
        public long ClientId { get; set; }        
        public long BusinessUnitId { get; set; }        
        public long BusinessAreaId { get; set; }        
        public long BusinessPartnerId { get; set; }        
        public string InvoiceCode { get; set; }        
        public long AdjustmentJournalId { get; set; }        
        public string AdjustmentJournalCode { get; set; }        
        public decimal Amount { get; set; }        
        public string Narration { get; set; }        
        public bool IsReceivable { get; set; }        
        public long PayTerm { get; set; }        
        public DateTime TransactionDate { get; set; }        
        public DateTime DueDate { get; set; }        
        public bool IsCleared { get; set; }        
        public DateTime? ClearingDate { get; set; }        
        public long ActionBy { get; set; }        
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
