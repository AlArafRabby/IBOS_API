using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PriceSetup
{
    public class CancelPriceSetupDTO
    {
        [Required]
        public long PriceConditionId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
