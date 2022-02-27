using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOrderType
{
    public class GetSalesOrderTypeDTO
    {
        public long SalesOrderTypeId { get; set; }
        public long BusinessUnitid { get; set; }
        public string BusinessUnitName { get; set; }
        public long SalesOrderGroupId { get; set; }
        public string SalesOrderGroupName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
