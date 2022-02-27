using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.DistributionChannel
{
    public class CancelDistributionChannelDTO
    {
        [Required]
        public long DistributionChannelId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
