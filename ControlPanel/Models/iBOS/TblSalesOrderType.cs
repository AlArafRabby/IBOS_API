using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOrderType
    {
        public long IntSalesOrderTypeId { get; set; }
        public long IntBusinessUnitid { get; set; }
        public long IntSalesOrderGroupId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
