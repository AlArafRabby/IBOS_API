using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOrderGroup
{
    public class GetSalesOrderGroupDTO
    {
        public long SalesOrderGroupId { get; set; }
        public string SalesOrderGroupName { get; set; }
        public bool? IsActive { get; set; }
    }
}
