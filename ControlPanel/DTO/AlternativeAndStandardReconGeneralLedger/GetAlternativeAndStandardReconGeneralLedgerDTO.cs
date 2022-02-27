using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AlternativeAndStandardReconGeneralLedger
{
    public class GetAlternativeAndStandardReconGeneralLedgerDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long GeneralLedgerId { get; set; }
        public string GeneralLedgerName { get; set; }
        public long AlternateGeneralLedgerId { get; set; }
        public string AlternateGeneralLedgerName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
