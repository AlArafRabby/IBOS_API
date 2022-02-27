using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBalanceCheckType
    {
        public long IntBalanceCheckTypeId { get; set; }
        public string StrBalanceCheckName { get; set; }
        public bool IsActive { get; set; }
    }
}
