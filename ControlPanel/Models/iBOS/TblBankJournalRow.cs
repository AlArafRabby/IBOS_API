using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBankJournalRow
    {
        public long IntRowId { get; set; }
        public long IntBankJournalId { get; set; }
        public string StrBankJournalCode { get; set; }
        public long IntGeneralLedgerId { get; set; }
        public string StrGeneralLedgerCode { get; set; }
        public string StrGeneralLedgerName { get; set; }
        public decimal NumAmount { get; set; }
    }
}
