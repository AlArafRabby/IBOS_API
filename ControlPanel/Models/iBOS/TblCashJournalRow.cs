using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblCashJournalRow
    {
        public long IntRowId { get; set; }
        public long IntCashJournalId { get; set; }
        public string StrCashJournalCode { get; set; }
        public long IntGeneralLedgerId { get; set; }
        public string StrGeneralLedgerCode { get; set; }
        public string StrGeneralLedgerName { get; set; }
        public decimal NumAmount { get; set; }
        public string StrNarration { get; set; }
    }
}
