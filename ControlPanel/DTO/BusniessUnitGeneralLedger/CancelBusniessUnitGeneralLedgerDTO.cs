using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusniessUnitGeneralLedger
{
    public class CancelBusniessUnitGeneralLedgerDTO
    {
        [Required]
        public long AutoId { get; set; }
        [Required]
        public long ActionBy { get; set; }


    }
}
