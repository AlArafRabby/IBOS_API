using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusniessUnitGeneralLedger
{
    public class GetBusniessUnitGeneralLedgerDTO
    {
        [Required]
        public long AutoId { get; set; }
        [Required]
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        [Required]
        public string BusinessUnitName { get; set; }
        public long GeneralLedgerId { get; set; }
        [Required]
        public string GeneralLedgerName { get; set; }
        [Required]
        public decimal CurrentBalance { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
