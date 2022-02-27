using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Plant
{
    public class EditPlantDTO
    {
        [Required]
        public long PlantId { get; set; }
        [Required]
        public string PlantCode { get; set; }
        [Required]
        public string PlantName { get; set; }
        [Required]
        public string PlantAddress { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
