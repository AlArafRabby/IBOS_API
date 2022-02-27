using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountReceivableRow
    {
        public long IntRowId { get; set; }
        public long IntAccountReceivablePayableId { get; set; }
        public string StrInvoiceCode { get; set; }
        public long IntDeliveryId { get; set; }
        public string StrDeliveryCode { get; set; }
        public long IntSalesOrderId { get; set; }
        public string StrSalesOrderCode { get; set; }
        public long IntDeliveryRowId { get; set; }
        public long IntItemId { get; set; }
        public string StrItemSalesCode { get; set; }
        public string StrItemSalesName { get; set; }
        public string StrItemCode { get; set; }
        public string StrItemName { get; set; }
        public long IntUom { get; set; }
        public string StrUom { get; set; }
        public decimal NumQuantity { get; set; }
        public decimal NumItemPrice { get; set; }
        public decimal NumDeliveryValue { get; set; }
        public decimal NumTotalDiscountValue { get; set; }
        public decimal NumTotalShipingValue { get; set; }
        public decimal NumTotalTax { get; set; }
        public decimal NumNetValue { get; set; }
        public bool IsFreeItem { get; set; }
        public bool IsActive { get; set; }
    }
}
