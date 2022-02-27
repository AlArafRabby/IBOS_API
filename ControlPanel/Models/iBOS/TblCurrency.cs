using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblCurrency
    {
        public long IntCurrencyId { get; set; }
        public string StrCurrencyName { get; set; }
        public string StrCurrencyCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
