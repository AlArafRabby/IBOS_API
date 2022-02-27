using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAdjustmentJournalRow
    {
        public long IntRowId { get; set; }
        public long IntAdjustmentJournalId { get; set; }
        public string StrAdjustmentJournalCode { get; set; }
        public long IntGeneralLedgerId { get; set; }
        public string StrGeneralLedgerName { get; set; }
        public string StrNarration { get; set; }
        public decimal NumAmount { get; set; }
    }
}
