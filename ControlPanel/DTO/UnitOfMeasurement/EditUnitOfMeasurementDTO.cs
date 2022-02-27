using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.UnitOfMeasurement
{
    public class EditUnitOfMeasurementDTO
    {
        [Required]
        public long Uomid { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string Uomname { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
