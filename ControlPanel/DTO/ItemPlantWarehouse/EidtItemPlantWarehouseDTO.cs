using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPlantWarehouse
{
    public class EidtItemPlantWarehouseDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public long WarehouseId { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
