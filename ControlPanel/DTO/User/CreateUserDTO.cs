using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.User
{
    public class CreateUserDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string LoginId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
