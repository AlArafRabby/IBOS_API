using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingModule.DTO.Price
{
    public class PriceReturnDTO
    {
        public decimal itemPrice { get; set; }
        public long priceConditionId { get; set; }
    }
}
