using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblPaymentTerms
    {
        public long IntPaymentTerms { get; set; }
        public string StrPaymentTermsName { get; set; }
        public string StrPaymentTermsCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
