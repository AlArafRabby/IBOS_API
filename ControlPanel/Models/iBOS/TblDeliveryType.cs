using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblDeliveryType
    {
        public long IntDeliveryTypeId { get; set; }
        public string StrDeliveryTypeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
