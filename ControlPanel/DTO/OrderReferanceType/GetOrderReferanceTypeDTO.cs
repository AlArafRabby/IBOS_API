using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.OrderReferanceType
{
    public class GetOrderReferanceTypeDTO
    {
        public long OrderReferanceTypeId { get; set; }
        public string OrderReferanceTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
