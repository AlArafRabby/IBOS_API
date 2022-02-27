using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessUnitCurrency
    {
        public long IntConfigId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntCurrencyId { get; set; }
        public bool IsBaseCurrency { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
