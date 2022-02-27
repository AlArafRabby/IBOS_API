using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPlantWarehouse
{
    public class GetItemPlantWarehouseDTO
    {
        [Required]
        public long Id { get; set; }
        public long BusinessUnitId { get; set; }
        public String BusinessUnitName { get; set; }
        public long PlantId { get; set; }
        public String PlantName { get; set; }
        public long ItemId { get; set; }
        public String ItemName { get; set; }
        public long WarehouseId { get; set; }
        public String WarehouseName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
