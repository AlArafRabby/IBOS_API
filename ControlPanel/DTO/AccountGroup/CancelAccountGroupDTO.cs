using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountGroup
{
    public class CancelAccountGroupDTO
    {
        [Required]
        public long AccountGroupId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
