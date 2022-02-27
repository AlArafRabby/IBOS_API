using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Territory
{
    public class CancelTerritoryDTO
    {
        [Required]
        public long TerritoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
