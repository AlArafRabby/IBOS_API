using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.User
{
    public class CancelUserDTO
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public long ActionBy { get; set; }


    }
}
