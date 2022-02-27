using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class CreateAccountReceivableRowDTO
    {
        [Required]
        public long AccountReceivablePayableId { get; set; }
        [Required]
        public string InvoiceCode { get; set; }
        [Required]
        public long DeliveryId { get; set; }
        [Required]
        public string DeliveryCode { get; set; }
        [Required]
        public long SalesOrderId { get; set; }
        [Required]
        public string SalesOrderCode { get; set; }
        [Required]
        public long DeliveryRowId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public string ItemSalesCode { get; set; }
        [Required]
        public string ItemSalesName { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public long IntUom { get; set; }
        [Required]
        public string StrUom { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal ItemPrice { get; set; }
        [Required]
        public decimal DeliveryValue { get; set; }
        [Required]
        public decimal TotalDiscountValue { get; set; }
        [Required]
        public decimal TotalShipingValue { get; set; }
        [Required]
        public decimal TotalTax { get; set; }
        [Required]
        public decimal NetValue { get; set; }
        [Required]
        public bool IsFreeItem { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
