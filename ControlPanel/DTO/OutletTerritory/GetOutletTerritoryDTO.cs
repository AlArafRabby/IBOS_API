using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.OutletTerritory
{
    public class GetOutletTerritoryDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long TerritoryId { get; set; }
        public string TerritoryName { get; set; }
        public long OutletId { get; set; }
        public string OutletName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
