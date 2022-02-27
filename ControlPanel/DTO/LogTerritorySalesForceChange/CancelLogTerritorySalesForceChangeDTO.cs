using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.LogTerritorySalesForceChange
{
    public class CancelLogTerritorySalesForceChangeDTO
    {
        [Required]
        public long LogId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
