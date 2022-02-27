using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class GetAccountPayableRowDTO
    {
        [Required]
        public long RowId { get; set; }
        [Required]
        public long AccountReceivablePayableId { get; set; }
        public string InvoiceCode { get; set; }
        public long DeliveryId { get; set; }
        public string DeliveryCode { get; set; }
        public long SalesOrderId { get; set; }
        public string SalesOrderCode { get; set; }
        public long DeliveryRowId { get; set; }
        public long ItemId { get; set; }
        public string ItemSalesCode { get; set; }
        public string ItemSalesName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public long IntUom { get; set; }
        public string StrUom { get; set; }
        public decimal Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal DeliveryValue { get; set; }
        public decimal TotalDiscountValue { get; set; }
        public decimal TotalShipingValue { get; set; }
        public decimal TotalTax { get; set; }
        public decimal NetValue { get; set; }
        public bool IsFreeItem { get; set; }
        public bool IsActive { get; set; }
    }
}
