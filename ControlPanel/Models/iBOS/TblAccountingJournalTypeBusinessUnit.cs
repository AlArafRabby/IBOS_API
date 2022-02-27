using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountingJournalTypeBusinessUnit
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public string StrPrefix { get; set; }
        public bool IsYear { get; set; }
        public bool IsMonth { get; set; }
        public long IntMonthlyNumberLength { get; set; }
        public long IntYearlyNumberLength { get; set; }
        public bool IsMonthlyNumberChange { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
