using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Price
{
    public class PriceReturnDTO
    {
        public decimal itemPrice { get; set; }
        public long priceConditionId { get; set; }
    }
}
