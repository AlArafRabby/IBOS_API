using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PlantWarehouse
{
    public class CreatePlantWarehouseDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public string PlantName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public DateTime ServerDateTime { get; set; }
    }
}
