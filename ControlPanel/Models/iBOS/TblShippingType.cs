using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblShippingType
    {
        public long IntShippingTypeId { get; set; }
        public string StrShippingTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
