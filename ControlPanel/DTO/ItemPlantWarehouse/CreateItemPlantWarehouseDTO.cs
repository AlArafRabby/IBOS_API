using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPlantWarehouse
{
    public class CreateItemPlantWarehouseDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
