using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAdjustmentJournalHeader
    {
        public long IntAdjustmentJournalId { get; set; }
        public string StrAdjustmentJournalCode { get; set; }
        public DateTime DteJournalDate { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public decimal NumDebitAmount { get; set; }
        public decimal NumCreditAmount { get; set; }
        public string StrNarration { get; set; }
        public bool IsPosted { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public bool IsDirectPosting { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
