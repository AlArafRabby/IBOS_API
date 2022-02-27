using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountClass
{
    public class EditAccountClassDTO
    {
        [Required]
        public long AccountClassId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long AccountGroupId { get; set; }
        [Required]
        public string AccountClassName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
