using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PricingModule.DTO.Price
{
    public class PriceDTO
    {
        public long Unit { get; set; }
        public long Partner { get; set; }
        public long ItemId { get; set; }
        public long Terr { get; set; }
        public long Channel { get; set; }
        public long SOrg { get; set; }
        public long ProdDivision { get; set; }
        public decimal Qty { get; set; }
        public DateTime PricingDate { get; set; }
        public decimal numPrice { get; set; }
        public decimal Value { get; set; }
        public long PriceConditionId { get; set; }


        /*
         @intUnit int=1, @intPartner int=30, @intItem int=1, @intTerr int=7, @intChannel int=2, @intSOrg int=26, 
              @intProdDivision int=1, @numQty numeric(18,6)=100, @dtePricingDate date='2020-02-18',
              @numPrice numeric(18,6), @numValue numeric(18,6), @intPriceConditionId Int
                            
       --Check Price by Customer
       SELECT @numPrice=numPrice, @intPriceConditionId=intPriceConditionId FROM iBOS.sado.tblPriceSetup 
       Where intConditionTypeId=4 and intConditionReffId=@intPartner and intItemId=@intItem
              and dteStartDate<=@dtePricingDate and @dtePricingDate<=ISNULL(dteEndDate,@dtePricingDate) and isActive=1
         
         */

    }
}
