using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountClass
{
    public class CancelAccountClassDTO
    {
        [Required]
        public long AccountClassId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
