using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblWarehouse
    {
        public long IntWarehouseId { get; set; }
        public long IntClientId { get; set; }
        public string StrWarehouseCode { get; set; }
        public string StrWarehouseName { get; set; }
        public string StrWarehouseAddress { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
