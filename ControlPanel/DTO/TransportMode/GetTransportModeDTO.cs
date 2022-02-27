using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TransportMode
{
    public class GetTransportModeDTO
    {
        [Required]
        public long TransportModeId { get; set; }
        public string TransportModeName { get; set; }
    }
}
