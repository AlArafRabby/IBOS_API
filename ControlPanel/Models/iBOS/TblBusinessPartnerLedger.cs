using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessPartnerLedger
    {
        public long IntTransactionId { get; set; }
        public DateTime DteTransactionDate { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntBusinessPartnerId { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public string StrAccountingJournalTypeName { get; set; }
        public decimal NumAmount { get; set; }
        public decimal NumRunningAmount { get; set; }
        public string StrNarration { get; set; }
        public long IntAccountingJournalId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
