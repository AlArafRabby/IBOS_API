using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblPlantWarehouse
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntWarehouseId { get; set; }
        public string StrWarehouseName { get; set; }
        public long IntPlantId { get; set; }
        public string StrPlantName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
