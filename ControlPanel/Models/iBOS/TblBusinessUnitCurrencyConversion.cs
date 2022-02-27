using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessUnitCurrencyConversion
    {
        public int IntConfigId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBaseCurrencyId { get; set; }
        public long IntAlternateCurrencyId { get; set; }
        public decimal NumConversionRate { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
