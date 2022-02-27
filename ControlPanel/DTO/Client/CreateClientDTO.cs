using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Client
{
    public class CreateClientDTO
    {
        [Required]
        public string ClientCode { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string ClientAddress { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
