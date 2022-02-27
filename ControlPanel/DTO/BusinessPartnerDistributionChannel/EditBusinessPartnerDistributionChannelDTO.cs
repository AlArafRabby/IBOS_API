using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerDistributionChannel
{
    public class EditBusinessPartnerDistributionChannelDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public long DistributionChannelId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
