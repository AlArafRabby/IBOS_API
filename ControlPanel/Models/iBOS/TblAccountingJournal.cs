using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountingJournal
    {
        public long IntTrasactionId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public long IntAccountingJournalId { get; set; }
        public string StrAccountingJournalCode { get; set; }
        public DateTime DteTransactionDate { get; set; }
        public long IntGeneralLedgerId { get; set; }
        public string StrGeneralLedgerCode { get; set; }
        public string StrGeneralLedgerName { get; set; }
        public decimal NumAmount { get; set; }
        public string StrNarration { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
