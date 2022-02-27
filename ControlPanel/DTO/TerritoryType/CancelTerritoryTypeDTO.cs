using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TerritoryType
{
    public class CancelTerritoryTypeDTO
    {
        [Required]
        public long TerritoryTypeId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
