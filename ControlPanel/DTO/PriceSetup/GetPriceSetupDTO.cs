using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PriceSetup
{
    public class GetPriceSetupDTO
    {
        [Required]
        public long PriceConditionId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ConditionTypeId { get; set; }
        public string ConditionTypeName { get; set; }
        public long ConditionReffId { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
