using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Warehouse
{
    public class EditWarehouseDTO
    {
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public string WarehouseCode { get; set; }
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public string WarehouseAddress { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
