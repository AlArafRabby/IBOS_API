using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.User
{
    public class GetUserDTO
    {
        [Required]
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string LoginId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
