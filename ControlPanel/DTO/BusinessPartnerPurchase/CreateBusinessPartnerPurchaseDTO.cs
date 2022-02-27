using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerWarehousePurchase
{
    public class CreateBusinessPartnerPurchaseDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public long PurchaseOrganizationId { get; set; }
        [Required]
        public decimal LedgerBalance { get; set; }
        [Required]
        public decimal UnbilledAmount { get; set; }
        [Required]
        public decimal CreditLimit { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public DateTime ServerDateTime { get; set; }

    }
}
