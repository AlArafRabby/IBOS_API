using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Client
{
    public class CancelClientDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
