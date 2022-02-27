using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountGroup
{
    public class CreateAccountGroupDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string AccountGroupCode { get; set; }
        [Required]
        public string AccountGroupName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
