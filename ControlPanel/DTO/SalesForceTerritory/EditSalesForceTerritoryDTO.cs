using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesForceTerritory
{
    public class EditSalesForceTerritoryDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long TerritoryId { get; set; }
        [Required]
        public long EmployeeId { get; set; }
        [Required]
        public bool YsnManager { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
