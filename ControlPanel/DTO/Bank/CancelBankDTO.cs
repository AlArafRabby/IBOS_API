using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Bank
{
    public class CancelBankDTO
    {
        [Required]
        public long BankId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
