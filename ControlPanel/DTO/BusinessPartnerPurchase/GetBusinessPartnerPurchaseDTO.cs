using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerWarehousePurchase
{
    public class GetBusinessPartnerPurchaseDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long BusinessPartnerId { get; set; }
        public string BusinessPartnerName { get; set; }
        public long PurchaseOrganizationId { get; set; }
        public string PurchaseOrganizationName { get; set; }
        public decimal LedgerBalance { get; set; }
        public decimal UnbilledAmount { get; set; }
        public decimal CreditLimit { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
