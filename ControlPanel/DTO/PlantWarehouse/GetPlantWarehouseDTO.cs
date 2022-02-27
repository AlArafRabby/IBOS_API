using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PlantWarehouse
{
    public class GetPlantWarehouseDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long PlantId { get; set; }
        public string PlantName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
