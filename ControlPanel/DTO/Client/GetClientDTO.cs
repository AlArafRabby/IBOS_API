using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Client
{
    public class GetClientDTO
    {
        [Required]
        public long ClientId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
