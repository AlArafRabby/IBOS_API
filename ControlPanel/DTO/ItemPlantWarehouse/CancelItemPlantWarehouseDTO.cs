﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemPlantWarehouse
{
    public class CancelItemPlantWarehouseDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
