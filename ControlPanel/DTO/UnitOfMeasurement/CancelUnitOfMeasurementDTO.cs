using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.UnitOfMeasurement
{
    public class CancelUnitOfMeasurementDTO
    {
        [Required]
        public long Uomid { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
