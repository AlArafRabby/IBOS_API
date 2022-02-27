using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountingJournalCodeGenerator
    {
        public long IntAccountCodeGenerateId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUintId { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public string StrAccountingJournalTypeName { get; set; }
        public long IntYear { get; set; }
        public long IntMonth { get; set; }
        public long IntCount { get; set; }
    }
}
