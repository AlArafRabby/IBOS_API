using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblPriceConditionTypeOrganization
    {
        public long IntPriceConditionTypeId { get; set; }
        public string StrPriceConditionTypeName { get; set; }
        public string StrPriceConditionTypeCode { get; set; }
        public long? IntAccessSequence { get; set; }
    }
}
