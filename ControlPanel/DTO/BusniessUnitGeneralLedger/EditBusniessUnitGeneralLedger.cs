using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusniessUnitGeneralLedger
{
    public class EditBusniessUnitGeneralLedgerDTO
    {
        [Required]
        public long AutoId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public decimal CurrentBalance { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
