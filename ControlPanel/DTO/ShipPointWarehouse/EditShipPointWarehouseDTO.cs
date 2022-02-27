using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ShipPointWarehouse
{
    public class EditShipPointWarehouseDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public long ShipPointId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime DteLastActionDateTime { get; set; }
    }
}
