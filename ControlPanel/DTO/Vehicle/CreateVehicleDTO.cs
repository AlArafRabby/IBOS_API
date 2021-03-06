using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Vehicle
{
    public class CreateVehicleDTO
    {
        [Required]
        public string VehicleNo { get; set; }
        [Required]
        public string VehicleCode { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime DteLastActionDateTime { get; set; }
    }
}
