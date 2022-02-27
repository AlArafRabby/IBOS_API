using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Vehicle
{
    public class CancelVehicleDTO
    {
        [Required]
        public long VehicleId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
