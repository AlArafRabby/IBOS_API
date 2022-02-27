using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesArea
{
    public class EditSalesAreaDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long DistributionChannelId { get; set; }
        [Required]
        public long ProductDivisionId { get; set; }
        [Required]
        public long SalesOrganizationId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
