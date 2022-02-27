using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TradeOfferSetupRow
{
    public class GetTradeOfferSetupRowDTO
    {
        [Required]
        public long RowId { get; set; }
        public long TradeOfferConditionId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public bool ValueBase { get; set; }
        public bool SlabProgram { get; set; }
        public decimal BaseFrom { get; set; }
        public decimal BaseTo { get; set; }
        public decimal OfferPercent { get; set; }
        public decimal OfferAmount { get; set; }
        public long OfferItemId { get; set; }
        public long OfferItemUom { get; set; }
        public decimal OfferQuantity { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
