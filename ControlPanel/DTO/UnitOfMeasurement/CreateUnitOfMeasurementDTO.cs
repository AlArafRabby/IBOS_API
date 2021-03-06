using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.UnitOfMeasurement
{
    public class CreateUnitOfMeasurementDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string Uomname { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
  
    }
}
