using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerLedger
{
    public class CancelBusinessPartnerLedgerDTO
    {
        [Required]
        public long TransactionId { get; set; }
        public long ActionBy { get; set; }

    }
}
