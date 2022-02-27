using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPurchase
{
    public class GetItemPurchaseDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long PlantId { get; set; }
        public string PlantName { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string PurchaseDescription { get; set; }
        public string Hscode { get; set; }
        public decimal MaxLeadDays { get; set; }
        public decimal MinLeadDays { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public decimal LotSize { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
