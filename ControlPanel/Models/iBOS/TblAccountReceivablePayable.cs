using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountReceivablePayable
    {
        public long IntAccountReceivablePayableId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntBusinessPartnerId { get; set; }
        public string StrInvoiceCode { get; set; }
        public long IntAdjustmentJournalId { get; set; }
        public string StrAdjustmentJournalCode { get; set; }
        public decimal NumAmount { get; set; }
        public string StrNarration { get; set; }
        public bool IsReceivable { get; set; }
        public long IntPayTerm { get; set; }
        public DateTime DteTransactionDate { get; set; }
        public DateTime DteDueDate { get; set; }
        public bool IsCleared { get; set; }
        public DateTime? DteClearingDate { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
