using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOrderHeader
    {
        public long IntSalesOrderId { get; set; }
        public long IntSalesOrderTypeId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntSalesOrganizationId { get; set; }
        public long IntSalesOfficeId { get; set; }
        public long IntDistributionChannelId { get; set; }
        public string StrSalesOrderCode { get; set; }
        public DateTime DteSalesOrderDate { get; set; }
        public DateTime DtePricingDate { get; set; }
        public string StrPartnerReffNo { get; set; }
        public DateTime DtePartnerReffDate { get; set; }
        public long IntSoldToPartnerId { get; set; }
        public long IntBillToPartnerId { get; set; }
        public DateTime DteDueShippingDate { get; set; }
        public bool IsPartialShipment { get; set; }
        public bool IsTransshipment { get; set; }
        public long IntIncotermId { get; set; }
        public long IntPaymentTermId { get; set; }
        public long IntPaymentInstrumentId { get; set; }
        public string StrPaymentInstrumentNo { get; set; }
        public decimal NumTotalOrderValue { get; set; }
        public decimal NumHeaderDiscountValue { get; set; }
        public decimal NumRowDiscountValue { get; set; }
        public decimal NumNetOrderValue { get; set; }
        public bool IsApproved { get; set; }
        public long IntApprovedBy { get; set; }
        public DateTime DteApprovedDateTime { get; set; }
        public bool IsCompleted { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
