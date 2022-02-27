using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemType
{
    public class CancelItemTypeDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
