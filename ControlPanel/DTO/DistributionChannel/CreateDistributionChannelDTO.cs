using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.DistributionChannel
{
    public class CreateDistributionChannelDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string DistributionChannelCode { get; set; }
        [Required]
        public string DistributionChannelName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
        public DateTime ServerDateTime { get; set; }
    }
}
