using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PlantWarehouse
{
    public class EditPlantWarehouseDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public string PlantName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }


    }
}
