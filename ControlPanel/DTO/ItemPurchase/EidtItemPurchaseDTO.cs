using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPurchase
{
    public class EidtItemPurchaseDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public long PurchaseOrganizationId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public string PurchaseDescription { get; set; }
        [Required]
        public string Hscode { get; set; }
        [Required]
        public decimal MaxLeadDays { get; set; }
        [Required]
        public decimal MinLeadDays { get; set; }
        [Required]
        public decimal MinOrderQuantity { get; set; }
        [Required]
        public decimal LotSize { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
