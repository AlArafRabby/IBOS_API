using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Vehicle
{
    public class GetVehicleDTO
    {
        [Required]
        public long VehicleId { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleCode { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
