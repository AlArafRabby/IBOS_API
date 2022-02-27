using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Plant
{
    public class CancelPlantDTO
    {
        [Required]
        public long PlantId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
