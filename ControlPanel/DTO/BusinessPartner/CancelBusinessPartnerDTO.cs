using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class CancelBusinessPartnerDTO
    {
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
