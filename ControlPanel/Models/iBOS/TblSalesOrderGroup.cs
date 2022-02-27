using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOrderGroup
    {
        public long IntSalesOrderGroupId { get; set; }
        public string StrSalesOrderGroupName { get; set; }
        public bool? IsActive { get; set; }
    }
}
