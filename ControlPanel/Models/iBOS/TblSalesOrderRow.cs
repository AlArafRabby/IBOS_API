using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOrderRow
    {
        public long IntRowId { get; set; }
        public long IntSalesOrderId { get; set; }
        public long IntShipToPartnerId { get; set; }
        public string StrShipToPartnerName { get; set; }
        public string StrShipToPartnerAddress { get; set; }
        public long IntItemId { get; set; }
        public decimal NumRequestQuantity { get; set; }
        public decimal NumOrderQuantity { get; set; }
        public decimal NumDeliveredQuantity { get; set; }
        public long IntPriceConditionId { get; set; }
        public long IntTradeOfferConditionId { get; set; }
        public decimal NumItemPrice { get; set; }
        public decimal NumOrderValue { get; set; }
        public decimal NumDiscountValue { get; set; }
        public decimal NumNetValue { get; set; }
        public bool IsFreeItem { get; set; }
    }
}
