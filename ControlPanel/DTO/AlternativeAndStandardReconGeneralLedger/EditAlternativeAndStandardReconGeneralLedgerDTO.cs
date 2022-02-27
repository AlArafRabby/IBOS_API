using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AlternativeAndStandardReconGeneralLedger
{
    public class EditAlternativeAndStandardReconGeneralLedgerDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public long AlternateGeneralLedgerId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
