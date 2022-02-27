using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblOrderReferanceType
    {
        public long IntOrderReferanceTypeId { get; set; }
        public string StrOrderReferanceTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
