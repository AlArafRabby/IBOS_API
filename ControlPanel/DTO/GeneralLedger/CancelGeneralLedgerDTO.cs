using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.GeneralLedger
{
    public class CancelGeneralLedgerDTO
    {
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public long ActionBy { get; set; }


    }
}
