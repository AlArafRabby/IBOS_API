using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Warehouse
{
    public class CancelWarehouseDTO
    {
        [Required]
        public long WarehouseId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
