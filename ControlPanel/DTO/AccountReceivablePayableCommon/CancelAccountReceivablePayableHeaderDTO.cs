using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class CancelAccountReceivablePayableHeaderDTO
    {
        [Required]
        public long AccountReceivablePayableId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
