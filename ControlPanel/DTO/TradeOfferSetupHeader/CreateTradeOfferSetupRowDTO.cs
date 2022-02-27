using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupRow
{
    public class CreateTradeOfferSetupRowDTO
    {
        [Required]
        public long TradeOfferConditionId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public string BusinessUnitName { get; set; }
        [Required]
        public bool ValueBase { get; set; }
        [Required]
        public bool SlabProgram { get; set; }
        [Required]
        public decimal BaseFrom { get; set; }
        [Required]
        public decimal BaseTo { get; set; }
        [Required]
        public decimal OfferPercent { get; set; }
        [Required]
        public decimal OfferAmount { get; set; }
        [Required]
        public long OfferItemId { get; set; }
        [Required]
        public long OfferItemUom { get; set; }
        [Required]
        public decimal OfferQuantity { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
