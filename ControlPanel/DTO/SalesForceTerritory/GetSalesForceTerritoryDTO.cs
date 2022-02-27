using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesForceTerritory
{
    public class GetSalesForceTerritoryDTO
    {
        public long ConfigId { get; set; }
        public long BusinessUnitId{ get; set; }
        public string BusinessUnitName { get; set; }
        public long TerritoryId { get; set; }
        public string TerritoryName { get; set; }
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public bool YsnManager { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
