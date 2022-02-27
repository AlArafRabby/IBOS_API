using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessPartnerSales
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntBusinessPartnerId { get; set; }
        public long IntSalesOrganizationId { get; set; }
        public decimal NumLedgerBalance { get; set; }
        public decimal NumUnbilledAmount { get; set; }
        public decimal NumCreditLimit { get; set; }
        public long IntBalanceCheckTypeId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
