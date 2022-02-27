using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblGeneralLedger
    {
        public long IntGeneralLedgerId { get; set; }
        public long IntClientId { get; set; }
        public long IntAccountGroupId { get; set; }
        public long IntAccountClassId { get; set; }
        public long IntAccountCategoryId { get; set; }
        public string StrGeneralLedgerCode { get; set; }
        public string StrGeneralLedgerName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
